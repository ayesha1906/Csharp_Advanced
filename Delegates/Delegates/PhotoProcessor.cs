namespace Delegates
{
    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo);

        /*
        public void Process(string path)
        {
            var photo = Photo.Load(path);
            var filters = new PhotoFilters();
            filters.ApplyBrightness(photo);
            filters.ApplyContrast(photo);
            filters.Resize(photo);

            photo.Save();
        }
        */
         // initially we can use the above commented method. But when we use delegate we can do :

        public void Process(string path, PhotoFilterHandler filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo);
            photo.Save();
        }
        
    }
}
