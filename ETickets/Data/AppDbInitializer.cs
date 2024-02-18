using ETickets.Models;

namespace ETickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if (context != null)
                {
                    context.Database.EnsureCreated();

                    if (!context.Cinemas.Any())
                    {
                        context.Cinemas.AddRange(new List<Cinema>()
                        {
                            new Cinema()
                            {
                                Name = "Cinema 1",
                                Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                                Description = "This is the first cinema",
                            },
                            new Cinema()
                            {
                                Name = "Cinema 2",
                                Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                                Description = "This is the second cinema",
                            },
                            new Cinema()
                            {
                                Name = "Cinema 3",
                                Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                                Description = "This is the third cinema",
                            },
                            new Cinema()
                            {
                                Name = "Cinema 4",
                                Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                                Description = "This is the fourth cinema",
                            }
                        });
                        context.SaveChanges();
                    }
                    if (!context.Actors.Any())
                    {
                        context.Actors.AddRange(new List<Actor>()
                        {
                            new Actor()
                            {
                                Bio = "This is the first actor",
                                FullName = "Carlos Gaston Lucero Skamlec",
                                ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg",
                            },
                            new Actor()
                            {
                                Bio = "This is the second actor",
                                FullName = "Carlos Javier",
                                ProfilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg",
                            },
                            new Actor()
                            {
                                Bio = "This is the third actor",
                                FullName = "Hernesto de la Serna",
                                ProfilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg",
                            },
                            new Actor()
                            {
                                Bio = "This is the fourth actor",
                                FullName = "Jimen de la Cruz",
                                ProfilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg",
                            },
                            new Actor()
                            {
                                Bio = "This is the fith actor",
                                FullName = "Carlos Gaston Lucero Skamlec the Second",
                                ProfilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg",
                            }
                        });
                        context.SaveChanges();
                    }
                    if (!context.Producers.Any())
                    {
                        context.Producers.AddRange(new List<Producer>()
                        {
                            new Producer()
                            {
                                Bio = "asdasd",
                                FullName= "asdasdasd",
                                ProfilePictureURL = "http://dotnethow.net/images/producres/producer-1.jpeg"
                            },
                            new Producer()
                            {
                                Bio = "asdasd",
                                FullName= "asdasdasd",
                                ProfilePictureURL = "http://dotnethow.net/images/producres/producer-2.jpeg"
                            },
                            new Producer()
                            {
                                Bio = "asdasd",
                                FullName= "asdasdasd",
                                ProfilePictureURL = "http://dotnethow.net/images/producres/producer-3.jpeg"
                            },
                            new Producer()
                            {
                                Bio = "asdasd",
                                FullName= "asdasdasd",
                                ProfilePictureURL = "http://dotnethow.net/images/producres/producer-4.jpeg"
                            },
                            new Producer()
                            {
                                Bio = "asdasd",
                                FullName= "asdasdasd",
                                ProfilePictureURL = "http://dotnethow.net/images/producres/producer-5.jpeg"
                            }
                        });
                        context.SaveChanges();
                    }
                    if (!context.Movies.Any())
                    {
                        context.Movies.AddRange(new List<Movie>()
                        {
                            new Movie()
                            {
                                Name = "asdasd",
                                Description = "asdasd",
                                Price = 39.5,
                                ImageUrl = "http://dotnethow.net/images/movies/movie-1.jpeg",
                                StartDate = DateTime.Now.AddDays(-10),
                                EndDate = DateTime.Now.AddDays(-2),
                                CinemaId = 1,
                                ProducerId = 3,
                                MovieCategory = Enums.MovieCategory.Action
                            },
                            new Movie()
                            {
                                Name = "asdasd",
                                Description = "asdasd",
                                Price = 39.5,
                                ImageUrl = "http://dotnethow.net/images/movies/movie-2.jpeg",
                                StartDate = DateTime.Now.AddDays(-5),
                                EndDate = DateTime.Now.AddDays(-1),
                                CinemaId = 2,
                                ProducerId = 1,
                                MovieCategory = Enums.MovieCategory.Documentary
                            },
                            new Movie()
                            {
                                Name = "asdasd",
                                Description = "asdasd",
                                Price = 39.5,
                                ImageUrl = "http://dotnethow.net/images/movies/movie-3.jpeg",
                                StartDate = DateTime.Now.AddDays(-42),
                                EndDate = DateTime.Now.AddDays(-12),
                                CinemaId = 2,
                                ProducerId = 4,
                                MovieCategory = Enums.MovieCategory.Drama
                            },
                            new Movie()
                            {
                                Name = "asdasd",
                                Description = "asdasd",
                                Price = 39.5,
                                ImageUrl = "http://dotnethow.net/images/movies/movie-4.jpeg",
                                StartDate = DateTime.Now.AddDays(-15),
                                EndDate = DateTime.Now.AddDays(-10),
                                CinemaId = 4,
                                ProducerId = 4,
                                MovieCategory = Enums.MovieCategory.Comedy
                            }
                        });
                        context.SaveChanges();
                    }
                    if (!context.Actors_Movies.Any())
                    {
                        context.Actors_Movies.AddRange(new List<Actor_Movie>()
                        {
                            new Actor_Movie()
                            {
                                ActorId = 1,
                                MovieId = 2,
                            },
                            new Actor_Movie()
                            {
                                ActorId = 3,
                                MovieId = 1,
                            },
                            new Actor_Movie()
                            {
                                ActorId = 4,
                                MovieId = 3,
                            }
                        });
                        context.SaveChanges();
                    }
                }
            }
        }
    }
}
