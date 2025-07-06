using UnityEngine;

namespace UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets
{
    /// <summary>
    /// Script hiển thị hướng dẫn test việc đổi màu
    /// </summary>
    public class ColorChangeInstructions : MonoBehaviour
    {
        void Start()
        {
            Debug.Log("=== HƯỚNG DẪN TEST ĐỔI MÀU ===");
            Debug.Log("1. Chạy game và spawn một đối tượng bằng cách touch vào màn hình");
            Debug.Log("2. Đối tượng được spawn sẽ tự động có các component:");
            Debug.Log("   - ObjectColorChanger: Đổi màu khi click (XR interaction)");
            Debug.Log("   - ColorChangeTest: Test với phím T");
            Debug.Log("   - SimpleColorChanger: Test với phím C (đổi màu) và R (khôi phục)");
            Debug.Log("3. Cách test:");
            Debug.Log("   - Click vào đối tượng để đổi màu đỏ (XR interaction)");
            Debug.Log("   - Nhấn phím T để test đổi màu xanh");
            Debug.Log("   - Nhấn phím C để đổi màu đỏ, R để khôi phục");
            Debug.Log("4. Kiểm tra Console để xem log thông báo");
            Debug.Log("=== LƯU Ý ===");
            Debug.Log("- Đảm bảo đối tượng có Renderer component");
            Debug.Log("- Đảm bảo đối tượng có XRBaseInteractable component");
            Debug.Log("- Nếu không đổi màu được, kiểm tra Console để xem lỗi");
            Debug.Log("=== END ===");
        }
        
        void Update()
        {
            // Hiển thị hướng dẫn khi nhấn H
            if (Input.GetKeyDown(KeyCode.H))
            {
                ShowInstructions();
            }
        }
        
        void ShowInstructions()
        {
            Debug.Log("=== HƯỚNG DẪN CHI TIẾT ===");
            Debug.Log("CÁCH 1 - XR Interaction:");
            Debug.Log("- Click vào đối tượng để select");
            Debug.Log("- Đối tượng sẽ đổi thành màu đỏ");
            Debug.Log("- Bỏ chọn để khôi phục màu ban đầu");
            Debug.Log("");
            Debug.Log("CÁCH 2 - Bàn phím:");
            Debug.Log("- Nhấn T: Test đổi màu xanh (2 giây rồi khôi phục)");
            Debug.Log("- Nhấn C: Đổi màu đỏ");
            Debug.Log("- Nhấn R: Khôi phục màu ban đầu");
            Debug.Log("");
            Debug.Log("CÁCH 3 - Debug:");
            Debug.Log("- Kiểm tra Console để xem log");
            Debug.Log("- Nếu có lỗi, sẽ hiển thị trong Console");
            Debug.Log("=== END ===");
        }
    }
} 