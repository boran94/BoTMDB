

# BoTMDB
https://developers.themoviedb.org/3
C# .NET 6 ile yaptığım TheMovieDatabase API

Bu projede https://developers.themoviedb.org/3 sitesindeki tüm özellikler kullanılabilmektedir.
Proje yapısı https://developers.themoviedb.org/3 sitesindeki yapıyla aynı şekilde tasarlanmıştır.
Proje içerisinde ki sınıflar 

 - Account
 - Authentication 
 - Certifications
 - Changes
 - Collections
 - Companies
 - Configuration 
 - Credits 
 - Discover 
 - Find 
 - Genres 
 - Guest 
 - Sessions 
 - Keywords
 - Lists 
 - Movies 
 - Networks 
 - Trending 
 - People 
 - Reviews 
 - Search 
 - TV 
 - TV Seasons 
 - TV Episodes 
 - TV Episode Groups 
 - Watch Providers
 - **Tmdb**

Her sınıf kendi başına kullanılabilmektedir. Tmdb sınıfında diğer tüm sınıflara ulaşabildiğinden dolayı Tmdb sınıfı üzerinden çağırmak kullanım açısından kolaylık sağlamaktadır.

## Kullanım
```cs
Tmdb Tmdb = new Tmdb("api key");

Response<Session> a1 = Tmdb.Authentication.CreateGuestSession();
Response<RToken> a2 = Tmdb.Authentication.CreateRequestToken();
Response<Session> a3 = Tmdb.Authentication.CreateSession(a2.Data.RequestToken); //Request Token degerini onaylamayi unutmayiniz veya CreateSessionWithLogin metodunu kullanin.
Response<RToken> a4 = Tmdb.Authentication.CreateRequestToken();
Response<RToken> a5 = Tmdb.Authentication.CreateSessionWithLogin("kullanici adi", "sifre", a4.Data.RequestToken);


Response<Certificates> a7 = Tmdb.Certifications.GetMovieCertifications();
Response<Certificates> a8 = Tmdb.Certifications.GetTVCertifications();


Response<ChangeContainer> a9 = Tmdb.Changes.GetMovieChangeList(startDate: DateTime.Now.AddDays(-2));
Response<ChangeContainer> a10 = Tmdb.Changes.GetMovieChangeList(page: 2);
Response<ChangeContainer> a11 = Tmdb.Changes.GetMovieChangeList(DateTime.Now.AddDays(-12), DateTime.Now);
Response<ChangeContainer> a12 = Tmdb.Changes.GetTVChangeList(startDate: DateTime.Now.AddDays(-2));
Response<ChangeContainer> a13 = Tmdb.Changes.GetTVChangeList(page: 2);
Response<ChangeContainer> a14 = Tmdb.Changes.GetTVChangeList(DateTime.Now.AddDays(-12), DateTime.Now);
Response<ChangeContainer> a15 = Tmdb.Changes.GetPersonChangeList(startDate: DateTime.Now.AddDays(-2));
Response<ChangeContainer> a16 = Tmdb.Changes.GetPersonChangeList(page: 2);
Response<ChangeContainer> a17 = Tmdb.Changes.GetPersonChangeList(DateTime.Now.AddDays(-12), DateTime.Now);


Response<CollectionContainer> a18 = Tmdb.Collections.GetDetails(10);
Response<CollectionContainer> a19 = Tmdb.Collections.GetDetails(10, "tr");
Response<ImageContainer> a20 = Tmdb.Collections.GetImages(10);
Response<ImageContainer> a21 = Tmdb.Collections.GetImages(10, "de");
Response<TranslationContainer> a22 = Tmdb.Collections.GetTranslations(10);
Response<TranslationContainer> a23 = Tmdb.Collections.GetTranslations(10, "de");


Response<CompanyItem> a24 = Tmdb.Companies.GetDetails(3);
Response<CompanyAlternativeNames> a25 = Tmdb.Companies.GetAlternativeNames(3);
Response<CompanyLogos> a26 = Tmdb.Companies.GetImages(3);

Response<ConfigContainer> a27 = Tmdb.Configuration.GetAPIConfiguration();
Response<CountryList> a28 = Tmdb.Configuration.GetCountries();
Response<JobContainer> a29 = Tmdb.Configuration.GetJobs();
Response<LanguageContainer> a30 = Tmdb.Configuration.GetLanguages();
Response<List<string>> a31 = Tmdb.Configuration.GetPrimaryTranslations();
Response<TimezoneList> a32 = Tmdb.Configuration.GetTimezones();


Response<GenreList> a33 = Tmdb.Genres.GetMovieList();
Response<GenreList> a34 = Tmdb.Genres.GetMovieList("de");
Response<GenreList> a35 = Tmdb.Genres.GetTVList();
Response<GenreList> a36 = Tmdb.Genres.GetTVList("de");

Response<IdName> a37 = Tmdb.Keywords.GetDetails(3417);
Response<MovieContainer> a38 = Tmdb.Keywords.GetMovies(3417);
Response<MovieContainer> a39 = Tmdb.Keywords.GetMovies(10511, "de");
Response<MovieContainer> a40 = Tmdb.Keywords.GetMovies(10511, includeAdult: true);
Response<MovieContainer> a41 = Tmdb.Keywords.GetMovies(10511, includeAdult: true, page: 2);


Response<RegionContainer> a42 = Tmdb.WatchProviders.GetAvailableRegions();
Response<RegionContainer> a43 = Tmdb.WatchProviders.GetAvailableRegions("de");
Response<MediaProviders> a44 = Tmdb.WatchProviders.GetMovieProviders();
Response<MediaProviders> a45 = Tmdb.WatchProviders.GetMovieProviders(language: "de");
Response<MediaProviders> a46 = Tmdb.WatchProviders.GetMovieProviders("de", "de");
Response<MediaProviders> a47 = Tmdb.WatchProviders.GetTVProviders();
Response<MediaProviders> a48 = Tmdb.WatchProviders.GetTVProviders(language: "de");
Response<MediaProviders> a49 = Tmdb.WatchProviders.GetTVProviders("de", "de");


Response<NetworkItem> a50 = Tmdb.Networks.GetDetails(213);
Response<NetworkAlternativeName> a51 = Tmdb.Networks.GetAlternativeNames(174);
Response<NetworkImages> a52 = Tmdb.Networks.GetImages(213);


Response<ReviewContainer> a53 = Tmdb.Review.GetDetails("58aa82f09251416f92006a3a");

Response<Person> a54 = Tmdb.People.GetDetails(287);
Response<PersonChangeContainer> a55 = Tmdb.People.GetChanges(1167197);
Response<PersonChangeContainer> a56 = Tmdb.People.GetChanges(1167197, DateTime.Now.AddDays(-13));
Response<PersonChangeContainer> a57 = Tmdb.People.GetChanges(1167197, DateTime.Now.AddDays(-13), DateTime.Now.AddDays(-3));
Response<PersonChangeContainer> a58 = Tmdb.People.GetChanges(1167197, DateTime.Now.AddDays(-13), DateTime.Now.AddDays(-3), 2);
Response<MovieCreditsForPerson> a59 = Tmdb.People.GetMovieCredits(287);
Response<MovieCreditsForPerson> a60 = Tmdb.People.GetMovieCredits(287, "de");
Response<TvCreditsForPerson> a61 = Tmdb.People.GetTVCredits(287);
Response<TvCreditsForPerson> a62 = Tmdb.People.GetTVCredits(287, "de");
Response<CombinedCreditsForPerson> a63 = Tmdb.People.GetCombinedCredits(287);
Response<CombinedCreditsForPerson> a64 = Tmdb.People.GetCombinedCredits(287, "de");
Response<ExternalIdsForPerson> a65 = Tmdb.People.GetExternalIDs(287);
Response<PersonImage> a66 = Tmdb.People.GetImages(287);
Response<TaggedImageContainer> a67 = Tmdb.People.GetTaggedImages(10990);
Response<TaggedImageContainer> a68 = Tmdb.People.GetTaggedImages(10990, "de");
Response<PersonTranslationContainer> a69 = Tmdb.People.GetTranslations(287);
Response<PersonTranslationContainer> a70 = Tmdb.People.GetTranslations(287, "de");
Response<Person> a71 = Tmdb.People.GetLatest();
Response<Person> a72 = Tmdb.People.GetLatest("de");
Response<PopularPeople> a73 = Tmdb.People.GetPopular();
Response<PopularPeople> a74 = Tmdb.People.GetPopular("de");
Response<PopularPeople> a75 = Tmdb.People.GetPopular(page: 2);
Response<PersonWithAppend> a76 = Tmdb.People.GetDetailsWithAppend(287, appendToResponse: "changes,combined_credits,external_ids,images,movie_credits,tagged_images,tv_credits");


Response<Movie> a77 = Tmdb.Movies.GetDetails(120);
Response<Movie> a78 = Tmdb.Movies.GetDetails(120, "tr");
Response<RToken> a79 = Tmdb.Authentication.CreateRequestToken();
Response<RToken> a80 = Tmdb.Authentication.CreateSessionWithLogin("kullanıcı adı", "şifre", a79.Data.RequestToken);
Response<Session> a81 = Tmdb.Authentication.CreateSession(a80.Data.RequestToken);
Response<AccountState> a82 = Tmdb.Movies.GetAccountStates(120, a81.Data.SessionId);
Response<Session> a83 = Tmdb.Authentication.CreateGuestSession();
Response<AccountState> a84 = Tmdb.Movies.GetAccountStates(120, a81.Data.SessionId, a83.Data.SessionId);
Response<AlternativeTitlesForMedia> a85 = Tmdb.Movies.GetAlternativeTitles(120);
Response<AlternativeTitlesForMedia> a86 = Tmdb.Movies.GetAlternativeTitles(120, "fr");
Response<MediaChangeContainer> a87 = Tmdb.Movies.GetChanges(85192);
Response<MediaChangeContainer> a88 = Tmdb.Movies.GetChanges(85192, DateTime.Now.AddDays(-13));
Response<MediaChangeContainer> a89 = Tmdb.Movies.GetChanges(85192, DateTime.Now.AddDays(-13), DateTime.Now.AddDays(-3));
Response<MediaChangeContainer> a90 = Tmdb.Movies.GetChanges(85192, DateTime.Now.AddDays(-13), DateTime.Now.AddDays(-3), 2);
Response<MovieCredits> a91 = Tmdb.Movies.GetCredits(120);
Response<MovieCredits> a92 = Tmdb.Movies.GetCredits(120, "tr");
Response<ExternalItem> a93 = Tmdb.Movies.GetExternalIDs(120);
Response<ImageContainer> a94 = Tmdb.Movies.GetImages(120);
Response<MovieKeywords> a95 = Tmdb.Movies.GetKeywords(120);
Response<MovieListContainer> a96 = Tmdb.Movies.GetLists(120);
Response<MovieListContainer> a97 = Tmdb.Movies.GetLists(120, "fr");
Response<MovieListContainer> a98 = Tmdb.Movies.GetLists(120, page: 78);
Response<MovieListContainer> a99 = Tmdb.Movies.GetLists(120, "fr", 5);
Response<MovieContainer> a100 = Tmdb.Movies.GetRecommendations(120);
Response<MovieContainer> a101 = Tmdb.Movies.GetRecommendations(120, "fr");
Response<MovieContainer> a102 = Tmdb.Movies.GetRecommendations(120, page: 2);
Response<MovieContainer> a103 = Tmdb.Movies.GetRecommendations(120, "fr", 2);
Response<ReleaseDateContainer> a104 = Tmdb.Movies.GetReleasDates(120);
Response<MediaReview> a105 = Tmdb.Movies.GetReviews(120);
Response<MediaReview> a106 = Tmdb.Movies.GetReviews(120, "fr");
Response<MediaReview> a107 = Tmdb.Movies.GetReviews(120, "de");
Response<MovieContainer> a108 = Tmdb.Movies.GetSimilarMovies(120);
Response<MovieContainer> a109 = Tmdb.Movies.GetSimilarMovies(120, "fr");
Response<MovieContainer> a110 = Tmdb.Movies.GetSimilarMovies(120, page: 2);
Response<MovieContainer> a111 = Tmdb.Movies.GetSimilarMovies(120, "fr", 2);
Response<MediaTranslationContainer> a112 = Tmdb.Movies.GetTranslations(120);
Response<MediaTranslationContainer> a113 = Tmdb.Movies.GetTranslations(120, "de");
Response<VideoContainer> a114 = Tmdb.Movies.GetVideos(120);
Response<VideoContainer> a115 = Tmdb.Movies.GetVideos(120, "tr");
Response<ProviderContainer> a116 = Tmdb.Movies.GetWatchProviders(120);
Response<Status> a117 = Tmdb.Movies.RateMovie(121, 7, a81.Data.SessionId);
Response<Status> a118 = Tmdb.Movies.RateMovie(122, a83.Data.SessionId, 6.5M);
Response<Status> a119 = Tmdb.Movies.DeleteRating(121, a81.Data.SessionId);
Response<Status> a120 = Tmdb.Movies.DeleteRating(a83.Data.SessionId, 123);
Response<MovieItem> a121 = Tmdb.Movies.GetLatest();
Response<MovieItem> a122 = Tmdb.Movies.GetLatest("tr");
Response<NowPlayingMovieContainer> a123 = Tmdb.Movies.GetNowPlaying();
Response<NowPlayingMovieContainer> a124 = Tmdb.Movies.GetNowPlaying(language: "fr");
Response<NowPlayingMovieContainer> a125 = Tmdb.Movies.GetNowPlaying(language: "tr", region: "TR");
Response<MovieContainer> a126 = Tmdb.Movies.GetPopular();
Response<MovieContainer> a127 = Tmdb.Movies.GetPopular(language: "tr", region: "tr");
Response<MovieContainer> a128 = Tmdb.Movies.GetPopular(language: "tr", region: "tr", page: 2);
Response<MovieContainer> a129 = Tmdb.Movies.GetTopRated();
Response<MovieContainer> a130 = Tmdb.Movies.GetTopRated(language: "tr", region: "tr");
Response<MovieContainer> a131 = Tmdb.Movies.GetTopRated(language: "tr", region: "tr", page: 2);
Response<MovieContainer> a132 = Tmdb.Movies.GetUpcoming();
Response<MovieContainer> a133 = Tmdb.Movies.GetUpcoming(language: "tr", region: "tr");
Response<MovieContainer> a134 = Tmdb.Movies.GetUpcoming(language: "tr", region: "tr", page: 2);
Response<MovieWithAppend> a135 = Tmdb.Movies.GetDetailsWithAppend(120, appendToResponse: "alternative_titles,changes,credits,images,keywords,lists,releases,reviews,similar,translations,videos");


Response<TvItem> a136 = Tmdb.Tv.GetDetails(1418);
Response<TvItem> a137 = Tmdb.Tv.GetDetails(1418, "tr");
Response<AccountState> a138 = Tmdb.Tv.GetAccountStates(1418, a81.Data.SessionId);
Response<TvCredits> a139 = Tmdb.Tv.GetAggregateCredits(1418);
Response<TvCredits> a140 = Tmdb.Tv.GetAggregateCredits(1418, "tr");
Response<AlternativeTitlesForTv> a141 = Tmdb.Tv.GetAlternativeTitles(1418);
Response<AlternativeTitlesForTv> a142 = Tmdb.Tv.GetAlternativeTitles(1418, "tr");
Response<MediaChangeContainer> a143 = Tmdb.Tv.GetChanges(1418);
Response<MediaChangeContainer> a144 = Tmdb.Tv.GetChanges(1418, DateTime.Now.AddDays(-13));
Response<MediaChangeContainer> a145 = Tmdb.Tv.GetChanges(1418, DateTime.Now.AddDays(-13), DateTime.Now.AddDays(-3));
Response<MediaChangeContainer> a146 = Tmdb.Tv.GetChanges(1418, DateTime.Now.AddDays(-13), DateTime.Now.AddDays(-3), 2);
Response<ContentRating> a147 = Tmdb.Tv.GetContentRatings(1418);
Response<ContentRating> a148 = Tmdb.Tv.GetContentRatings(1418, "de");
Response<EpisodeGroupForTv> a149 = Tmdb.Tv.GetEpisodeGroups(1434);
Response<EpisodeGroupForTv> a150 = Tmdb.Tv.GetEpisodeGroups(1434, "de");
Response<ExternalIdsForTv> a151 = Tmdb.Tv.GetExternalIDs(1418);
Response<ExternalIdsForTv> a152 = Tmdb.Tv.GetExternalIDs(1418, "tr");
Response<ImageContainer> a153 = Tmdb.Tv.GetImages(1418);
Response<TvKeywords> a154 = Tmdb.Tv.GetKeywords(1418);
Response<TvContainer> a155 = Tmdb.Tv.GetRecommendations(1418);
Response<TvContainer> a156 = Tmdb.Tv.GetRecommendations(1418, "fr");
Response<TvContainer> a157 = Tmdb.Tv.GetRecommendations(1418, page: 2);
Response<TvContainer> a158 = Tmdb.Tv.GetRecommendations(1418, "fr", 2);
Response<MediaReview> a159 = Tmdb.Tv.GetReviews(1418);
Response<MediaReview> a160 = Tmdb.Tv.GetReviews(1418, "fr");
Response<MediaReview> a161 = Tmdb.Tv.GetReviews(1418, "de");
Response<ScreenedTheatrically> a162 = Tmdb.Tv.GetScreenedTheatrically(1399);
Response<TvContainer> a163 = Tmdb.Tv.GetSimilarTVShows(1418);
Response<TvContainer> a164 = Tmdb.Tv.GetSimilarTVShows(1418, "fr");
Response<TvContainer> a165 = Tmdb.Tv.GetSimilarTVShows(1418, page: 2);
Response<TvContainer> a166 = Tmdb.Tv.GetSimilarTVShows(1418, "fr", 2);
Response<MediaTranslationContainer> a167 = Tmdb.Tv.GetTranslations(1418);
Response<MediaTranslationContainer> a168 = Tmdb.Tv.GetTranslations(1418, "de");
Response<VideoContainer> a169 = Tmdb.Tv.GetVideos(1418);
Response<VideoContainer> a170 = Tmdb.Tv.GetVideos(1418, "de");
Response<ProviderContainer> a171 = Tmdb.Tv.GetWatchProviders(1418);
Response<Status> a172 = Tmdb.Tv.RateTVShow(1418, 9, a81.Data.SessionId);
Response<Status> a173 = Tmdb.Tv.RateTVShow(1434, a83.Data.SessionId, 6.5M);
Response<Status> a174 = Tmdb.Tv.DeleteRating(121, a81.Data.SessionId);
Response<Status> a175 = Tmdb.Tv.DeleteRating(a83.Data.SessionId, 123);
Response<TvItem> a176 = Tmdb.Tv.GetLatest();
Response<TvItem> a177 = Tmdb.Tv.GetLatest("de");
Response<TvContainer> a178 = Tmdb.Tv.GetTVAiringToday();
Response<TvContainer> a179 = Tmdb.Tv.GetTVAiringToday("de");
Response<TvContainer> a180 = Tmdb.Tv.GetTVOnTheAir();
Response<TvContainer> a181 = Tmdb.Tv.GetTVOnTheAir("DE");
Response<TvContainer> a182 = Tmdb.Tv.GetPopular();
Response<TvContainer> a183 = Tmdb.Tv.GetPopular(language: "tr", region: "tr");
Response<TvContainer> a184 = Tmdb.Tv.GetPopular(language: "tr", region: "tr", page: 2);
Response<TvContainer> a185 = Tmdb.Tv.GetTopRated();
Response<TvContainer> a186 = Tmdb.Tv.GetTopRated(language: "tr", region: "tr");
Response<TvContainer> a187 = Tmdb.Tv.GetTopRated(language: "tr", region: "tr", page: 2);
Response<TvWithAppend> a188 = Tmdb.Tv.GetDetailsWithAppend(1418, appendToResponse: "alternative_titles,changes,content_ratings,credits,external_ids,images,keywords,similar,translations,videos");

Response<TvSeason> a189 = Tmdb.TvSeasons.GetDetails(129473, 1);
Response<TvSeason> a190 = Tmdb.TvSeasons.GetDetails(1418, 2, "tr");
Response<AccountStateForTvSeason> a191 = Tmdb.TvSeasons.GetAccountStates(1418, 1, a81.Data.SessionId);
Response<TvCredits> a192 = Tmdb.TvSeasons.GetAggregateCredits(1418, 2);
Response<TvCredits> a193 = Tmdb.TvSeasons.GetAggregateCredits(1418, 2, "tr");
Response<MediaChangeContainer> a194 = Tmdb.TvSeasons.GetChanges(163789);
Response<TvCredits> a195 = Tmdb.TvSeasons.GetCredits(1418, 10);
Response<ExternalIdForSeasons> a196 = Tmdb.TvSeasons.GetExternalIDs(1418, 1);

Response<ImageContainer> a197 = Tmdb.TvSeasons.GetImages(1418, 10);
Response<MediaTranslationContainer> a198 = Tmdb.TvSeasons.GetTranslations(1418, 1);
Response<VideoContainer> a199 = Tmdb.TvSeasons.GetVideos(1418, 1);

Response<TvSeasonWithAppend> a200 = Tmdb.TvSeasons.GetDetailsWithAppend(1418, 1, appendToResponse: "changes,credits,external_ids,images,translations,videos");

Response<TvSeasonEpisode> a201 = Tmdb.TvEpisodes.GetDetails(1418, 1, 1);
Response<TvSeasonEpisode> a202 = Tmdb.TvEpisodes.GetDetails(1418, 1, 1, "tr");
Response<AccountStateForEpisode> a203 = Tmdb.TvEpisodes.GetAccountStates(1418, 1, 1, a81.Data.SessionId);
Response<MediaChangeContainer> a204 = Tmdb.TvEpisodes.GetChanges(3211256);
Response<EpisodeCredits> a205 = Tmdb.TvEpisodes.GetCredits(1418, 10, 5);
Response<ExternalIdForSeasons> a206 = Tmdb.TvEpisodes.GetExternalIDs(1399, 1, 1);
Response<EpisodeImageContainer> a207 = Tmdb.TvEpisodes.GetImages(1418, 1, 5);
Response<MediaTranslationContainer> a208 = Tmdb.TvEpisodes.GetTranslations(1418, 1, 5);
Response<Status> a209 = Tmdb.TvEpisodes.RateTVEpisode(1418, 10, 1, 9, a81.Data.SessionId);
Response<Status> a210 = Tmdb.TvEpisodes.RateTVEpisode(1434, 10, 1, a83.Data.SessionId, 6.5M);
Response<Status> a211 = Tmdb.TvEpisodes.DeleteRating(1418, 10, 1, a81.Data.SessionId);
Response<Status> a212 = Tmdb.TvEpisodes.DeleteRating(1434, 10, 1, a83.Data.SessionId);
Response<VideoContainer> a213 = Tmdb.TvEpisodes.GetVideos(1399, 1, 2);
Response<TvSeasonEpisodeWithAppend> a214 = Tmdb.TvEpisodes.GetDetailsWithAppend(1418, 1, 2, appendToResponse: "alternative_titles,changes,content_ratings,credits,external_ids,images,keywords,similar,translations,videos");

Response<EpisodeGroup> a215 = Tmdb.TvEpisodeGroups.GetDetails("5acf93e60e0a26346d0000ce");


Response<CreditItem> a216 = Tmdb.Credits.GetDetails("52542282760ee313280017f9");

Response<MovieContainer> a217 = Tmdb.Trending.GetTrendingForMovie(TimeWindow.Week);
Response<MovieContainer> a218 = Tmdb.Trending.GetTrendingForMovie(TimeWindow.Week, 2);

Response<TvContainer> a219 = Tmdb.Trending.GetTrendingForTv(TimeWindow.Week);
Response<TvContainer> a220 = Tmdb.Trending.GetTrendingForTv(TimeWindow.Week, 2);

Response<ObjectContainer> a221 = Tmdb.Trending.GetTrendingForPerson(TimeWindow.Week);
Response<ObjectContainer> a222 = Tmdb.Trending.GetTrendingForPerson(TimeWindow.Week, 2);

Response<Session> a223 = Tmdb.Authentication.CreateGuestSession();

Response<Status> a224 = Tmdb.Movies.RateMovie(121, a223.Data.SessionId, 6.5M);
Response<Status> a225 = Tmdb.Movies.RateMovie(122, a223.Data.SessionId, 6.5M);

Response<Status> a226 = Tmdb.Tv.RateTVShow(1418, a223.Data.SessionId, 6.5M);
Response<Status> a227 = Tmdb.Tv.RateTVShow(1434, a223.Data.SessionId, 6.5M);


Response<Status> a228 = Tmdb.TvEpisodes.RateTVEpisode(1418, 10, 1, a223.Data.SessionId, 6.5M);
Response<Status> a229 = Tmdb.TvEpisodes.RateTVEpisode(1434, 10, 1, a223.Data.SessionId, 6.5M);

Response<MovieContainer> a230 = Tmdb.GuestSessions.GetRatedMovies(a223.Data.SessionId);
Response<TvContainer> a231 = Tmdb.GuestSessions.GetRatedTVShows(a223.Data.SessionId);
Response<EpisodeContainer> a232 = Tmdb.GuestSessions.GetRatedTVEpisodes(a223.Data.SessionId);

Response<FindContainer> a233 = Tmdb.Find.FindById("tt0944947", ExternalSourceIds.ImdbId);
Response<FindContainer> a234 = Tmdb.Find.FindById("tt0120737", ExternalSourceIds.ImdbId);
Response<FindContainer> a235 = Tmdb.Find.FindById("tt0120737", ExternalSourceIds.ImdbId, "tr");


Response<AccountItem> a236 = Tmdb.Account.GetDetails(a81.Data.SessionId);


Response<ListContainer> a237 = Tmdb.Account.GetCreatedLists(a81.Data.SessionId, 8383608);
Response<MovieContainer> a238 = Tmdb.Account.GetFavoriteMovies(a81.Data.SessionId, 8383608);
Response<TvContainer> a239 = Tmdb.Account.GetFavoriteTVShows(a81.Data.SessionId, 8383608);

Response<Status> a240 = Tmdb.Account.MarkAsFavorite(a81.Data.SessionId, 8383608, 76479, MediaType.Tv, true);

Response<RatedMovieContainer> aa238 = Tmdb.Account.GetRatedMovies(a81.Data.SessionId, 8383608);
Response<RatedTvContainer> aa239 = Tmdb.Account.GetRatedTVShows(a81.Data.SessionId, 8383608);
Response<RatedEpisodeContainer> aa240 = Tmdb.Account.GetRatedTVEpisodes(a81.Data.SessionId, 8383608);

Response<MovieContainer> a241 = Tmdb.Account.GetMovieWatchlist(a81.Data.SessionId, 8383608);
Response<TvContainer> a242 = Tmdb.Account.GetTVShowWatchlist(a81.Data.SessionId, 8383608);
Response<Status> a243 = Tmdb.Account.AddToWatchlist(a81.Data.SessionId, 8383608, 76479, MediaType.Tv, true);

Response<SearchCompanyContainer> a244 = Tmdb.Search.SearchCompanies("netfli");
Response<SearchCollectionContainer> a245 = Tmdb.Search.SearchCollections("lord");

Response<SearchKeywordContainer> a246 = Tmdb.Search.SearchKeywords("sci");
Response<MovieContainer> a247 = Tmdb.Search.SearchMovies("sci");
Response<ObjectContainer> a248 = Tmdb.Search.MultiSearch("bra");
Response<SearchPeopleContainer> a249 = Tmdb.Search.SearchPeople("brad");
Response<SearchTvContainer> a250 = Tmdb.Search.SearchTVShows("game of");


Response<RToken> aa79 = Tmdb.Authentication.CreateRequestToken();
Response<RToken> aa80 = Tmdb.Authentication.CreateSessionWithLogin("kullanıcı adı", "şifre", aa79.Data.RequestToken);
Response<Session> aa81 = Tmdb.Authentication.CreateSession(aa80.Data.RequestToken);
Response<MovieContainer> a251 = Tmdb.Account.GetMovieWatchlist(a81.Data.SessionId, 8383608);






Response<ListsContainer> a252 = Tmdb.Lists.GetDetails(8175486);

Response<PresentItem> a253 = Tmdb.Lists.CheckItemStatus(8175486, 315635);

Response<ListResult> a254 = Tmdb.Lists.CreateList(a81.Data.SessionId, "Yeni Liste 2", "açıklama", "tr");



Response<Status> a255 = Tmdb.Lists.AddMovie(a81.Data.SessionId, 8190602, 524434);
Response<Status> a256 = Tmdb.Lists.RemoveMovie(a81.Data.SessionId, 8190602, 315635);
Response<Status> a257 = Tmdb.Lists.ClearList(a81.Data.SessionId, 8190602, true);
Response<Status> a258 = Tmdb.Lists.DeleteList(a81.Data.SessionId, 8190602);


Response<MovieContainer> a259 = Tmdb.Discover.MovieDiscover(language: "tr");
Response<TvContainer> a260 = Tmdb.Discover.TVDiscover(language: "tr");
```

***Not:*** Yukarıdaki kod içerisinde bulunan değerleri bazı metodlar için değiştirmeniz gerekebilir. Örneğin Liste kodlarındaki liste Id değeri benim hesabıma ait olduğu için kendi liste Id degerinizi almaniz gerekmektedir.

