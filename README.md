# Practice API

## Опис проєкту
Цей проєкт реалізує RESTful API з повним набором CRUD операцій: **GET**, **POST**, **PATCH**, **DELETE**.  
API побудовано відповідно до стандартів REST, з використанням **.NET 8**, і документовано через **Postman**.

---

## Endpoints
API містить наступні endpoints:

| Метод  | Endpoint            | Опис                                |
|--------|-------------------|------------------------------------|
| GET    | /items             | Отримати список всіх елементів     |
| GET    | /items/{id}        | Отримати один елемент за ID        |
| POST   | /items             | Створити новий елемент             |
| PATCH  | /items/{id}        | Оновити існуючий елемент           |
| DELETE | /items/{id}        | Видалити елемент за ID             |

> Примітка: замініть `/items` на назву вашої сутності, якщо вона інша.

---

## Документація
Всі endpoints задокументовані у **Postman**:  
[Перейти до документації Postman](https://documenter.getpostman.com/view/ТУТ_ТВОЄ_ПОСИЛАННЯ)

---

## Інструкція запуску проєкту

### 1. Встановлення .NET SDK 8
Завантажити: [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)

### 2. Клонування репозиторію
```bash
git clone https://github.com/ТВІЙ_АКАУНТ/TechPrakt2025API.git
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

## Приклади запитів

**GET усіх елементів**
```http
GET https://localhost:7239/items
```

**POST нового елемента**
```http
POST https://localhost:7239/items
Content-Type: application/json

{
  "name": "Новий елемент",
  "description": "Опис елемента"
}
```

**PATCH оновлення елемента**
```http
PATCH https://localhost:7239/items/1
Content-Type: application/json

{
  "name": "Оновлена назва"
}
```

**DELETE елемента**
```http
DELETE https://localhost:7239/items/1
```

