# VIZCore3D.NET.MouseIdleDetector

`VIZCore3D.NET.MouseIdleDetector`는 **VIZCore3D.NET** 뷰어를 기반으로 **마우스 유휴 상태를 감지하여 라이선스 서버 연결을 자동으로 해제**하는 데모 애플리케이션입니다.

이 프로젝트는 일정 시간 동안 사용자 입력(마우스 움직임)이 없을 경우, 불필요한 라이선스 서버 점유를 방지하기 위해 **자동으로 연결을 해제**하는 기능을 포함합니다.

---

## 🧩 주요 기능

- 사용자 마우스 활동 감지 (폼 전체 + VIZCore3D 내부)
- 지정된 유휴 시간 초과 시 라이선스 서버 자동 해제
- 재접속 버튼 (`btn_Open`)을 통한 수동 연결 재시도

---

## ⚙️ 시스템 요구 사항

- .NET Framework 4 이상
- VIZCore3D.NET 라이브러리 및 라이선스
- Windows Forms 기반 UI
- 라이선스 서버 접근 가능 (기본: `127.0.0.1:8901`)

---

## 🚀 사용 방법

1. **라이선스 서버 주소 및 유휴 시간 설정**  
   `Form1.cs` 파일의 다음 변수를 필요에 따라 수정합니다:

   ```csharp
   private int idleThresholdSeconds = 30;  // 초 단위
   private readonly string LicenseServerIP = "127.0.0.1";
   private readonly int LicenseServerPort = 8901;
   ```

2. **실행**  
   프로젝트를 빌드하고 실행하면 `VIZCore3D.NET` 컨트롤이 로드되고, 마우스 활동을 감지하여 유휴 상태를 체크합니다.

3. **활동 없음 → 연결 해제**  
   사용자의 마우스가 30초 이상 움직이지 않으면 다음과 같은 알림이 표시되며 라이선스 연결이 자동으로 해제됩니다.
> "앱 내부에서 마우스 움직임이 없으므로 라이선스 서버를 해제 합니다."

4. **재연결 시도**  
   `btn_Open` 버튼 클릭 시 라이선스 서버에 재연결을 시도하고 모델 파일을 열 수 있습니다.