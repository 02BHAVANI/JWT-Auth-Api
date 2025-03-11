# JWT-Auth-Api

This project demonstrates JWT-based authentication in an ASP.NET Core Web API. It includes user login, token generation, and secure access to protected endpoints.

## 🔑 How It Works?

### 1️⃣ User Login & Token Generation (POST Request)
The user sends login credentials (username, password) to `/api/login/login`.
If valid, the API returns a JWT token.

#### Request:
```http
POST https://localhost:7263/api/login/login
Content-Type: application/json

{
    "username": "admin",
    "password": "password123"
}
```

#### Response:
```json
{
    "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9..."
}
```

### 2️⃣ Accessing Protected Endpoint (GET Request with Token)
The user sends a `GET` request to `/api/product/getproduct`, attaching the JWT token in the `Authorization` header.

- If valid, the API returns product details.
- If missing or invalid, it returns `401 Unauthorized`.

#### Request:
```http
GET https://localhost:7263/api/product/getproduct
Authorization: Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...
```

#### Response:
```json
{
    "id": 1,
    "name": "Laptop",
    "price": 75000
}
```

## 🚀 Getting Started

### 🔧 Prerequisites
- Install [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- Install [Postman](https://www.postman.com/) (or use Curl for API testing)

### 💻 Setup Instructions

#### 1️⃣ Clone the repository:
```sh
git clone https://github.com/yourusername/JwtAuthApi.git
cd JwtAuthApi
```

#### 2️⃣ Install dependencies:
```sh
dotnet restore
```

#### 3️⃣ Run the application:
```sh
dotnet run
```

#### 4️⃣ Use Postman or cURL to test login and API endpoints.

## 🛠 Configuration
Modify the JWT settings in `appsettings.json`:

```json
"Jwt": {
    "Key": "MySuperSecretKey1234567890",
    "Issuer": "JwtAuthApi",
    "Audience": "JwtAuthApiUsers"
}
```

✔ Ensure the secret key is at least **32 characters** to prevent security issues.

## 📜 License
This project is licensed under the [MIT License](LICENSE).

