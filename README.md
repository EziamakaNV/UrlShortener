# .NET 7 URL Shortener Web API

Welcome to the .NET 7 URL Shortener Web API project. This project is a minimal API solution that takes a long URL and returns a unique short URL. When a user navigates to the short URL, they are redirected to the original long URL.

## Prerequisites

- [.NET 7.0 SDK](https://dotnet.microsoft.com/download/dotnet/7.0)
- [Docker](https://www.docker.com/get-started)
- [Docker Compose](https://docs.docker.com/compose/install/)

## Getting Started

Clone the repository to your local machine:

```sh
git clone https://github.com/EziamakaNV/UrlShortener.git
```

Navigate to the project directory:
```sh
cd UrlShortener
```

## Running the Application with Docker Compose
To build and run the application using Docker Compose, execute the following command in the project root directory:
```sh
docker-compose up --build
```
The API will be accessible at http://localhost:5001

## Usage

### Create a Short URL
To create a short URL, make a POST request to the api/shorten endpoint with the long URL in the request body. Here is an example using curl:

```sh
curl -X POST -H "Content-Type: application/json" -d '{"url": "https://www.your-long-url.com"}' http://localhost:5001/api/shorten
```

The API will return a string with the short URL.

### Navigate to a Short URL
To be redirected to the original URL, simply navigate to the short URL in your web browser.

## Development
```sh
dotnet run
```

## Contributing
If you would like to contribute to this project, please fork the repository and submit a pull request.

## Contact
If you have any questions or feedback, please reach out to me at eziamakanv@gmail.com