using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assignment6.EntityModels;
using Assignment6.Models;


namespace Assignment6.Controllers
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
            Mapper.Initialize(cfg1 =>
            {
                cfg1.CreateMap<PlayListWithDetails, PlayListEditTrackFormViewModel>();
                Mapper.Reset();
            });
            // Configure the AutoMapper components
            var config = new MapperConfiguration(cfg =>
            {

                // Define the mappings below, for example...
                // cfg.CreateMap<SourceType, DestinationType>();
                // cfg.CreateMap<Employee, EmployeeBase>();
                cfg.CreateMap<Track, TrackBaseViewModel>();
                cfg.CreateMap<Playlist, PlayListBaseViewModel>();
                cfg.CreateMap<PlayListEditTrackViewModel, Track>();
                cfg.CreateMap<PlayListEditTrackFormViewModel,Playlist>();
                cfg.CreateMap<Playlist, PlayListWithDetails>();
                cfg.CreateMap<Playlist, PlayListEditTrackFormViewModel>();
                cfg.CreateMap<PlayListWithDetails, PlayListEditTrackFormViewModel>();
                cfg.CreateMap< PlayListEditTrackFormViewModel, PlayListWithDetails>();
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
        public IEnumerable<TrackBaseViewModel> TrackGetAll()
        {
            var obj = ds.Tracks.OrderBy(ln => ln.Name);
            return mapper.Map <IEnumerable<Track>, IEnumerable<TrackBaseViewModel>>(obj);
        }

        public IEnumerable<PlayListBaseViewModel> PlaylistGetAll()
        {
            var obj = ds.Playlists.Include("Tracks").OrderBy(ln => ln.Name);
            return mapper.Map<IEnumerable<Playlist>, IEnumerable<PlayListBaseViewModel>>(obj);
        }
        // ProductGetById()
        public PlayListWithDetails PlayListGetById(int id)
        {
            var obj = ds.Playlists.Include("Tracks").SingleOrDefault(ln => ln.PlaylistId == id);
            return (obj == null) ? null : mapper.Map<Playlist, PlayListWithDetails>(obj);
        }
        // ProductAdd()
        // ProductEdit()
        public PlayListWithDetails PlaylistEdit(PlayListEditTrackViewModel edit)
        {
            var obj = ds.Playlists.Include("Tracks") .SingleOrDefault(e => e.PlaylistId == edit.Id);

            if (obj == null)
            {
                return null;
            }
            else
            {
                obj.Tracks.Clear(); ;
                foreach (var item in edit.TrackId)
                {
                    var a = ds.Tracks.Find(item);                    
                    obj.Tracks.Add(a);
                }
                ds.SaveChanges();
                return Mapper.Map<PlayListWithDetails>(obj);
            }
        }
        // ProductDelete()
    }
}