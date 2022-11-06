using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMED_V1
{
    public class MusicPlayer
    {
        private static MusicPlayer instance;
        private System.Media.SoundPlayer player;
        /*
        private MusicPlayer()
        {
            player = new System.Media.SoundPlayer();
        }

        public static MusicPlayer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MusicPlayer();
                }
                return instance;
            }
        }

        public void Play(string path)
        {/*
        try{
            var p = Path.GetFullPath(path);
          
            
}
        catch(Exception e){}}
        public static void PlayInicio()
        {
        try{
            var player = new System.Media.SoundPlayer();
            player.SoundLocation = @"archivos\\musica simed.wav";
            player.Play();}
        catch(Exception e){}
        }
        public void Stop()
        {
            player.Stop();
        }*/
    }
}
