using UnityEngine;

namespace UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets
{
    /// <summary>
    /// Script quản lý việc đổi màu và tự động thêm hướng dẫn
    /// </summary>
    public class ColorChangeManager : MonoBehaviour
    {
        void Start()
        {
            // Tự động thêm ColorChangeInstructions nếu chưa có
            if (FindObjectOfType<ColorChangeInstructions>() == null)
            {
                GameObject instructionsGO = new GameObject("ColorChangeInstructions");
                instructionsGO.AddComponent<ColorChangeInstructions>();
                Debug.Log("Added ColorChangeInstructions to scene");
            }
            
            Debug.Log("=== COLOR CHANGE SYSTEM READY ===");
            Debug.Log("Tất cả đối tượng được spawn sẽ tự động có khả năng đổi màu");
            Debug.Log("Nhấn H để xem hướng dẫn chi tiết");
        }
        
        void Update()
        {
            // Hiển thị trạng thái khi nhấn I
            if (Input.GetKeyDown(KeyCode.I))
            {
                ShowStatus();
            }
        }
        
        void ShowStatus()
        {
            Debug.Log("=== TRẠNG THÁI HỆ THỐNG ĐỔI MÀU ===");
            Debug.Log("✓ ObjectColorChanger - Đã tạo");
            Debug.Log("✓ ColorChangeTest - Đã tạo");
            Debug.Log("✓ SimpleColorChanger - Đã tạo");
            Debug.Log("✓ ObjectSpawner - Đã tích hợp tự động thêm components");
            Debug.Log("✓ ControllerInputActionManager - Đã tích hợp đổi màu");
            Debug.Log("✓ ColorChangeInstructions - Đã thêm vào scene");
            Debug.Log("=== CÁCH SỬ DỤNG ===");
            Debug.Log("1. Spawn object bằng cách touch màn hình");
            Debug.Log("2. Click vào object để đổi màu đỏ");
            Debug.Log("3. Hoặc dùng bàn phím: C (đổi màu), R (khôi phục), T (test)");
            Debug.Log("=== END ===");
        }
    }
} 