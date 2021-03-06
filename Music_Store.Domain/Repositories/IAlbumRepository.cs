﻿using Music_Store.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Music_Store.Domain.Repositories
{
    public interface IAlbumRepository
    {
        List<Album> SearchAlbum();
        List<Album> SearchAlbumById(int id);
        void CreateAlbum(Album album);
        void AlterAlbum(Album album);
        void DeleteAlbum(int id);
    }
}
