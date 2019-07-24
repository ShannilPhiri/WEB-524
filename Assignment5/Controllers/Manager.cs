using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assignment5.EntityModels;
using Assignment5.Models;

namespace Assignment5.Controllers
{
    public class Manager
    {
        // Reference to the data context
        private DataContext ds = new DataContext();

        // AutoMapper instance
        public IMapper mapper;

        public Manager()
        {
            // If necessary, add more constructor code here...

            // Configure the AutoMapper components
            var config = new MapperConfiguration(cfg =>
            {
                // Define the mappings below, for example...
                // cfg.CreateMap<SourceType, DestinationType>();
                // cfg.CreateMap<Employee, EmployeeBase>();
                cfg.CreateMap<Track, TrackBaseViewModel>();
                cfg.CreateMap<TrackBaseViewModel, Track>();
                cfg.CreateMap<Album, AlbumBaseViewModel>();
                cfg.CreateMap<MediaType, MediaTypeBaseViewModel>();
                cfg.CreateMap<Track, TrackWithDetailViewModel>();
                cfg.CreateMap<MediaTypeBaseViewModel, TrackWithDetailViewModel>();
                cfg.CreateMap<TrackAddViewModel, Track>();
               
            });

            mapper = config.CreateMapper();

            // Turn off the Entity Framework (EF) proxy creation features
            // We do NOT want the EF to track changes - we'll do that ourselves
            ds.Configuration.ProxyCreationEnabled = false;

            // Also, turn off lazy loading...
            // We want to retain control over fetching related objects
            ds.Configuration.LazyLoadingEnabled = false;
        }

        // Add methods below
        // Controllers will call these methods
        // Ensure that the methods accept and deliver ONLY view model objects and collections
        // The collection return type is almost always IEnumerable<T>

        // Suggested naming convention: Entity + task/action
        // For example:
        // ProductGetAll()

        public IEnumerable<AlbumBaseViewModel> AlbumGetAll()
        {
            var obj = mapper.Map<IEnumerable<AlbumBaseViewModel>>(ds.Albums.OrderBy(ln => ln.Title));
            return obj;
        }
        // ProductGetById()

        public AlbumBaseViewModel AlbumGetByID(int id)
        {
            var temp = ds.Albums.Find(id);
            return (temp == null) ? null : mapper.Map<Album, AlbumBaseViewModel>(temp);
        }

        public IEnumerable<MediaTypeBaseViewModel> MediaTypeGetAll()
        {
            return mapper.Map<IEnumerable<MediaTypeBaseViewModel>>(ds.MediaTypes.OrderBy(ln => ln.MediaTypeId));
        }

        public MediaTypeBaseViewModel MediaTypeGetByID(int id)
        {
            var temp = ds.MediaTypes.Find(id);
            return (temp == null) ? null : mapper.Map<MediaType, MediaTypeBaseViewModel>(temp);
        }
        public IEnumerable<TrackBaseViewModel> TrackGetAll()
        {
            return mapper.Map<IEnumerable<TrackBaseViewModel>>(ds.Tracks.OrderBy(ln => ln.Name));
        }

        public TrackBaseViewModel TrackGetByID(int id)
        {
            var temp = ds.Tracks.Find(id);
            return (temp == null) ? null : mapper.Map<Track, TrackBaseViewModel>(temp);
        }

        public TrackWithDetailViewModel TrackGetByIdWithDetail(int id)
        {
            Track obj = ds.Tracks.Include("MediaType").Include("MediaType.Tracks.Album").SingleOrDefault(ln => ln.TrackId == id);
            return (obj == null) ? null : mapper.Map<Track, TrackWithDetailViewModel>(obj);
        }

        public TrackWithDetailViewModel TrackAddNewData(TrackAddFormViewModel track)
        {
            var obj = ds.Albums.Find(track.AlbumId);
            var temp = ds.MediaTypes.Find(track.MediaTypeId);

            if (obj == null)
            {
                return null;
            }
            else
            {
                var newItem = ds.Tracks.Add(mapper.Map<Track>(track));
                newItem.Album = obj;
                ds.SaveChanges();
                return (newItem == null) ? null : mapper.Map<TrackWithDetailViewModel>(newItem);
            }
        }
        // ProductAdd()
        // ProductEdit()
        // ProductDelete()
    }
}