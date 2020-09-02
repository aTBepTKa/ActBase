using ActBase.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ActBase.DbContext
{
    /// <summary>
    /// Заполнить базу данных тестовыми данными.
    /// </summary>
    class SeedData
    {
        private readonly ModelBuilder modelBuilder;
        public SeedData(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        public void SeedActs()
        {
            int materialId = 1;
            Material[] materials = new Material[]
            {
                new Material
                {
                    MaterialId = materialId++,
                    Name = "Грунт песчаный"
                },
                new Material
                {
                    MaterialId = materialId++,
                    Name = "Труба"
                },
                new Material
                {
                    MaterialId = materialId++,
                    Name = "Грунт местный"
                }
            };
            modelBuilder.Entity<Material>().HasData(materials);

            int actId = 1;
            Act[] acts = new Act[]
            {
                new Act
                {
                    ActId= actId++,
                    WorkName = "Устройство песчаного основания с уплотнением h=100мм под трубопровод сети канализации К2 (GUC) на участке от К438 до т.10",
                    NextWorkName = "Монтаж трубопровода сети канализации К2 (GUC) на участке от К438 до т.10",
                    BeginDate = new DateTime(2018,10,23),
                    EndDate = new DateTime(2018,10,24),
                    SignDate = new DateTime(2018,10,25),
                },
                new Act
                {
                    ActId= actId++,
                    WorkName = "Монтаж трубопровода сети канализации К2 (GUC) на участке от К438 до т.10",
                    NextWorkName = "Обратная засыпка трубопровода сети канализации К2 (GUC) на участке от К438 до т.10",
                    BeginDate = new DateTime(2018,10,26),
                    EndDate = new DateTime(2018,10,27),
                    SignDate = new DateTime(2018,10,28)
                },
                new Act
                {
                    ActId= actId++,
                    WorkName = "Обратная засыпка трубопровода сети канализации К2 (GUC) на участке от К438 до т.10",
                    NextWorkName = "Вертикальная планировка обратной засыпки  трубопровода сети канализации К2 (GUC) на отм. 179,290 на участке от К438 до т.10",
                    BeginDate = new DateTime(2018,10,29),
                    EndDate = new DateTime(2018,10,30),
                    SignDate = new DateTime(2018,10,31)
                }
            };
            modelBuilder.Entity<Act>().HasData(acts);

            int actMaterialId = 1;
            ActMaterial[] actMaterials = new ActMaterial[]
            {
                new ActMaterial
                {
                    ActMaterialId = actMaterialId++,
                    ActId = 1,
                    MaterialId = 1
                },
                new ActMaterial
                {
                    ActMaterialId = actMaterialId++,
                    ActId = 2,
                    MaterialId = 2
                },
                new ActMaterial
                {
                    ActMaterialId = actMaterialId++,
                    ActId = 3,
                    MaterialId = 3
                }
            };
            modelBuilder.Entity<ActMaterial>().HasData(actMaterials);
        }
    }
}
