# Hướng dẫn sử dụng ObjectColorChanger

## Mô tả
Script `ObjectColorChanger` cho phép đối tượng đổi màu thành màu đỏ khi được chọn và khôi phục màu ban đầu khi bỏ chọn.

## Cách sử dụng

### 1. Tự động thêm vào đối tượng được spawn
- Script đã được tích hợp vào `ObjectSpawner.cs`
- Tất cả đối tượng được spawn sẽ tự động có component `ObjectColorChanger`

### 2. Thêm thủ công vào đối tượng
1. Chọn đối tượng trong scene
2. Thêm component `ObjectColorChanger` từ Inspector
3. Điều chỉnh màu trong phần "Color Settings"

### 3. Cấu hình màu
- **Selected Color**: Màu khi đối tượng được chọn (mặc định: đỏ)
- **Original Color**: Màu ban đầu của đối tượng (mặc định: trắng)

## Cách hoạt động

1. **Khi click vào đối tượng**:
   - Event `selectEntered` được trigger
   - `OnSelectEntered()` được gọi
   - Đối tượng đổi màu thành màu đỏ

2. **Khi bỏ chọn đối tượng**:
   - Event `selectExited` được trigger
   - `OnSelectExited()` được gọi
   - Đối tượng khôi phục màu ban đầu

## Yêu cầu
- Đối tượng phải có component `XRBaseInteractable` (hoặc kế thừa từ nó)
- Đối tượng phải có component `Renderer`

## Debug
- Script sẽ in log khi đối tượng được chọn/bỏ chọn
- Kiểm tra Console để xem thông báo

## Tùy chỉnh
Bạn có thể thay đổi màu bằng cách:
```csharp
ObjectColorChanger colorChanger = GetComponent<ObjectColorChanger>();
colorChanger.SetSelectedColor(Color.blue); // Đổi thành màu xanh
colorChanger.SetOriginalColor(Color.yellow); // Đổi màu ban đầu thành vàng
``` 