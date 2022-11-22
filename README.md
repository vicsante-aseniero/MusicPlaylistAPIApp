# MusicPlaylistAPIApp
The goal of this exercise is to build an API that will allow users to create and manage music playlists of their favorite songs for their music library

## Specification
*Note: The application DOES NOT require authentication
- API should create a user
- API should create a playlist for a given user
- API should allow searching for a song to add to their playlist
- API should allow searching for an album to add to their playlist
- API should allow adding a song to a playlist
- API should allow adding an entire album to a playlist
- API should allow viewing all playlists for a user
  - Should provide an option to include or not include songs with playlist)

## Requirements
- Should be .NET 6 (or 7) API
- Should provide Swagger Document support for viewing and testing endpoints
- Should use SQLite (local db file) for storing data
- Should use Entity Framework for DB connectivity
- Should leverage iTunes Search API for music data

## Resources
- Visual Studio 2022 (or Visual Studio Code)
- Google (you may use Google to look up syntax and technical clarifications)
- iTunes Search API (details below)
- Reference: Apple Developer Search Documentation

Artist Search: https://itunes.apple.com/search?term={search term}&entity=musicArtist

Artist Details: https://itunes.apple.com/lookup?id={Artist ID}

Artist Albums: https://itunes.apple.com/lookup?id={Artist ID}&entity=album&country=US&limit=200

Album Songs: https://itunes.apple.com/lookup?id={Album ID}&entity=song

*Note: Album ID is “collectionId” from the Artist Album API
