using System;
using System.Collections.Generic;
using AutoMapper;
using PsychotherapistWebSite.Core.Models;
using PsychotherapistWebSite.Core.Repositories;
using PsychotherapistWebSite.Models;
using System.Data.Entity;
using System.Linq;
using PsychotherapistWebSite.Areas.User.Dtos;
using PsychotherapistWebSite.Core.Dtos;

namespace PsychotherapistWebSite.Persistance.Repositories
{
    public class InfoRepository: IInfoRepository
    {
        private readonly ApplicationDbContext _context;

        public InfoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Info GetInfo()
        {
            return _context.Info
                .Include(i =>i.Images)
                .Include(i => i.Adress)
                .FirstOrDefault();
        }


        public HomeInfoDto GetHomeInfo()
        {
            return _context.Info
                .Include(i => i.Adress)
                .Select(Mapper.Map<Info,HomeInfoDto>)
                .FirstOrDefault();
        }

        public void Add(Info info, Image[] images)
        {
            if (info == null) return;
            if (images == null) return;
            foreach (var image in images)
            {
                var imageTemp = _context.Images.FirstOrDefault(i => i.Id == image.Id);
                if (imageTemp == null) break;
                info.Images.Add(imageTemp);
            }
            _context.Info.Add(info);
        }

        public void Delete()
        {
            var info = _context.Info.FirstOrDefault();
            if (info != null)
                _context.Info.Remove(info);
        }

        public void Put(Info info, int image1, int image2)
        {
            var infoDb = _context.Info.FirstOrDefault(i => i.Id == info.Id);
            if (infoDb != null)
                Mapper.Map(info,infoDb);
            if (infoDb != null) infoDb.Images = _context.Images.Where(i => i.Id == image1 || i.Id == image2).ToList();
        }

        public string AboutMe()
        {
            var info = _context.Info.Select(i => i.AboutMe).FirstOrDefault();
            return info;
        }
    }
}