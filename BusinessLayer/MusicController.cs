using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BusinessLayer
{
    public class MusicController
    {
        public bool MusicError { get; set; }

        /// <summary>
        /// Get the full list of all music
        /// </summary>
        /// <returns></returns>
        public List<Music> GetMusicList()
        {
            var query1 = from p in PublicMedia_Controller.Instance.Context.MusicRepository.GetAll()
                         select p;

            return query1.ToList();
        }

        
        public void NewMusic(string bName, string titel, string genre, int year, string format)
        {
            try
            {
                Music newMusic = new Music();
                IEnumerable<User> users = PublicMedia_Controller.Instance.Context.UserRepository.GetAll();

                newMusic.MusicId = 0;
                newMusic.BandName = bName;
                newMusic.Titel = titel;
                newMusic.Genre = genre;
                newMusic.Year = year;
                newMusic.Format = format;
                PublicMedia_Controller.Instance.Context.MusicRepository.Add(newMusic);
                PublicMedia_Controller.Instance.Save();
            }
            catch (NullReferenceException e)
            {
                MusicError = true;
            }
        }
    }
}
