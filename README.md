# Practice API

*Перегуда Владислав ІПЗ-23-2*
## Опис проєкту
Цей проєкт реалізує RESTful API з повним набором CRUD операцій: **GET**, **POST**, **PATCH**, **DELETE**.  
API побудовано відповідно до стандартів REST, з використанням **.NET 8**, і документовано через **Postman**.

Проєкт створений за покроковою інструкцією з Visual Studio 2022, включає модель `Product` і контролер `ProductsController`.

---

## Endpoints
API містить наступні endpoints:

| Метод  | Endpoint            | Опис                                |
|--------|-------------------|------------------------------------|
| GET    | /api/products      | Отримати список всіх продуктів     |
| POST   | /api/products      | Створити новий продукт             |
| PATCH  | /api/products/{id} | Оновити продукт                     |
| DELETE | /api/products/{id} | Видалити продукт за ID             |

---

## Документація
Всі endpoints задокументовані у **Postman**:  
[Перейти до документації Postman](https://documenter.getpostman.com/view/53573150/2sBXinFVPf)

---

## Інструкція запуску проєкту

### 1. Встановлення .NET SDK 8
Завантажити: [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)

### 2. Клонування репозиторію
```bash
git clone https://github.com/VladyslavPerehuda/TechPrakt2025API
cd TechPrakt2025API
```

### 3. Встановлення залежностей
```bash
dotnet restore
```

### 4. Запуск сервера
```bash
cd API
dotnet run
```

### 5. Відкрити Swagger
Swagger UI доступний за адресою:  
[https://localhost:7239/swagger](https://localhost:7239/swagger)

---

## Приклади запитів через Postman

**GET усіх продуктів**
```http
GET https://localhost:7239/api/products
```

**POST нового продукту**
```http
POST https://localhost:7239/api/products
Content-Type: application/json

{
  "name": "Product3",
  "price": 35.99
}
```

**PATCH оновлення продукту**
```http
PATCH https://localhost:7239/api/products/1
Content-Type: application/json

{
  "name": "UpdatedProduct"
}
```

**DELETE продукту**
```http
DELETE https://localhost:7239/api/products/1
```

---

## Пояснення
- Створено проект **API** у Visual Studio 2022 з шаблоном ASP.NET Core Web API.
- Видалено стандартні файли `WeatherForecast.cs` та `WeatherForecastController.cs`.
- Додано Swagger для документування API.
- Створена модель `Product` і контролер `ProductsController` з CRUD операціями.
- Для тестування використовуйте Postman з вашого локального сервера (порт може відрізнятися).
- Документацію опубліковано через Postman, посилання вказано вище.
