# Authentication

## Register
### Request
```json
{
  "fullName": "Rayhanul Islam",
  "userName": "raj",
  "email": "raj@mail.com",
  "password": "123456"  
}
```
### Response
```json
{
  "id": "00000000-0000-0000-0000-000000000000",
  "fullName": "Rayhanul Islam",
  "userName": "raj",
  "email": "raj@mail.com",
  "token": "JWT Token"
}
```
## Login
### Request
```json
{  
  "email": "raj@mail.com",
  "password": "123456"  
}
```
### Response
```json
{
  "id": "00000000-0000-0000-0000-000000000000",
  "fullName": "Rayhanul Islam",
  "userName": "raj",
  "email": "raj@mail.com",
  "token": "JWT Token"
}
```