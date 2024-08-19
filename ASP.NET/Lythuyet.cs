namespace ASP.MVC
{
    public class Lythuyet
    {
        //1.  Tìm hiểu Asp .NET Core  và Asp .NET MVC là gì?
        /*
         ASP.NET Core và ASP.NET MVC là hai framework được phát triển bởi Microsoft để xây dựng các ứng dụng web

                ASP.NET MVC
                    ASP.NET MVC (Model-View-Controller) là một framework phát triển web dựa trên kiến trúc MVC.
                    Model đại diện cho dữ liệu và logic nghiệp vụ.
                    View là giao diện người dùng (UI), nơi dữ liệu được hiển thị.
                    Controller xử lý yêu cầu từ người dùng, tương tác với Model và trả về View tương ứng.
                    ASP.NET MVC được xây dựng trên nền tảng .NET Framework, là một phần của ASP.NET truyền thống.

                 Ưu điểm:

                    Dễ dàng quản lý và bảo trì code do việc tách biệt các thành phần Model, View, và Controller.
                    Hỗ trợ tốt cho việc kiểm thử (unit testing) và phát triển theo nhóm.
                Nhược điểm:
                    ASP.NET MVC phụ thuộc vào .NET Framework, không phải là lựa chọn tối ưu nếu bạn muốn xây dựng các ứng dụng đa nền tảng.

            ASP.NET Core

                    ASP.NET Core là một framework phát triển web mã nguồn mở và đa nền tảng, được Microsoft phát hành như là sự tiếp nối của ASP.NET.
                    ASP.NET Core có thể chạy trên nhiều hệ điều hành khác nhau như Windows, Linux, và macOS.
                    ASP.NET Core hỗ trợ xây dựng ứng dụng theo nhiều kiến trúc khác nhau, bao gồm MVC, API RESTful, Razor Pages, Blazor, SignalR, và nhiều hơn nữa.
                Ưu điểm:
                    Đa nền tảng: Chạy trên nhiều hệ điều hành, giúp mở rộng phạm vi sử dụng.
                    Hiệu suất cao: Được tối ưu hóa để có hiệu suất tốt hơn so với ASP.NET MVC.
                    Kiến trúc module: Cho phép tích hợp các tính năng mới một cách linh hoạt và dễ dàng.
                    Hỗ trợ cloud và container: Dễ dàng triển khai ứng dụng lên các nền tảng đám mây hoặc sử dụng Docker containers.
                Nhược điểm:
                    Do ASP.NET Core là một công nghệ mới hơn, nên có thể cần thêm thời gian học và chuyển đổi từ các công nghệ cũ hơn như ASP.NET MVC.
         */

        //2.1	Hiểu về MVC Partten

        /*
        MVC Pattern(Mô hình MVC) là một kiến trúc phần mềm phổ biến được sử dụng trong việc phát triển ứng dụng, đặc biệt là các ứng dụng web.MVC là viết tắt của Model-View-Controller, và mỗi thành phần trong mô hình này đóng một vai trò cụ thể trong việc tổ chức mã nguồn.

        Quy trình hoạt động của MVC:
            Người dùng thực hiện một hành động (ví dụ: nhấn nút, gửi biểu mẫu) qua View.
            View gửi yêu cầu này đến Controller.
            Controller xử lý yêu cầu bằng cách tương tác với Model để lấy dữ liệu hoặc thay đổi trạng thái của dữ liệu.
            Sau khi dữ liệu được xử lý, Controller gửi kết quả đến View.
            View cập nhật giao diện để hiển thị kết quả cho người dùng.
        Lợi ích của việc sử dụng MVC Pattern:
            Tách biệt rõ ràng các phần: Tạo ra sự tách biệt giữa giao diện người dùng, logic nghiệp vụ, và dữ liệu, giúp mã nguồn dễ bảo trì và mở rộng.
            Dễ kiểm thử: Các thành phần của ứng dụng có thể được kiểm thử độc lập.
            Tái sử dụng mã: Các phần khác nhau của ứng dụng có thể được tái sử dụng hoặc thay thế mà không ảnh hưởng đến các phần khác.
        */
    }
}
