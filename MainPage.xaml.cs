using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;

namespace JustCriadores
{
    public partial class MainPage : ContentPage
    {
        private List<Song> songs;
        private int currentIndex;

        public MainPage()
        {
            InitializeComponent();
            LoadSongs();
            DisplayCurrentSong();
        }

        
        public void LoadSongs()
        {
            songs = new List<Song>()
            {
                new Song { Title = "POP", Artist = "Taylor", AlbumCover = "tay.jpg"},
                new Song { Title = "Country", Artist = "tay", AlbumCover = "taylor.jpg" },
                new Song { Title = "POP BR", Artist = "iza", AlbumCover = "iza.jpg"},
                new Song { Title = "funk BR", Artist = "Mc livinho", AlbumCover = "livinho.jpg"},
                new Song { Title = "rap", Artist = "matue", AlbumCover = "matue.jpg"},
                new Song { Title = "sertenanejo", Artist = "Marilia medonça", AlbumCover = "marilia.jpg"}

            };
            currentIndex = 0;
        }

        
        private void DisplayCurrentSong()
        {
            if (currentIndex < songs.Count)
            {
                Song currentSong = songs[currentIndex];
                DisplayAlert("Debug", $"Playing: {currentSong.Title} by {currentSong.Artist}", "OK");
                AlbumCoverImage.Source = currentSong.AlbumCover; // Imagem do álbum
                SongTitle.Text = currentSong.Title;  // Título da música
                SongArtist.Text = currentSong.Artist; // Artista
            }
            else
            {
                AlbumCoverImage.Source = "no_more_songs.jpg";
                SongTitle.Text = "No more songs";
                SongArtist.Text = string.Empty;
            }
        }


        private void DislikeButton_Clicked(object sender, EventArgs e)
        {
            if (currentIndex < songs.Count)
            {
                currentIndex++;
                DisplayAlert("Dislike", "Voce nao curtiu essa musica!", "OK");
                DisplayCurrentSong();
            }
        }

        // Função que será chamada quando o botão 'Like' for clicado
        private void LikeButton_Clicked(object sender, EventArgs e)
        {
            if (currentIndex < songs.Count)
            {
                currentIndex++;
                DisplayAlert("Like", "Você adicionou na sua playlist!", "OK");
                DisplayCurrentSong(); 
            }
        }

        // Classe que representa uma música
        private class Song
        {
            public string? Title { get; set; }
            public string? Artist { get; set; }
            public string? AlbumCover { get; set; }
            public string? MusicUrl { get; set; }  // Caminho ou URL do arquivo de música
        }
    }
}

