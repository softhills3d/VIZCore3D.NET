# 📦 VIZCore3D.NET.ShortutsAreaSelectionBox

`VIZCore3D.NET.ShortutsAreaSelectionBox`는 VIZCore3D.NET 컨트롤을 이용하여  
**사용자 정의 단축키로 영역 선택(Selection Box)을 활성화하고**,  
**영역 선택의 시작/끝 좌표를 처리하는 예제 프로젝트**입니다.

---

## 🚀 주요 기능

- VIZCore3D.NET 컨트롤 초기화 및 패널에 바인딩
- 기본 영역 선택 단축키 비활성화
- `Ctrl + Shift + W` 단축키로 영역 선택 모드 실행
- **영역 선택 시작 이벤트(`Begin`)**, 종료 이벤트(`End`) 핸들링
- 영역 선택 시 **사용자 정의 텍스트 표시**
- 선택된 **시작/끝 좌표 디버깅 출력**

---

## 🧱 구성 요소

### ▶️ `Form1.cs`

| 구성 | 설명 |
|------|------|
| `vizcore3d` | VIZCore3D.NET 컨트롤 인스턴스 |
| `VIZCore3D_OnInitializedVIZCore3D` | 컨트롤 초기화 및 이벤트 등록 |
| `View_OnAreaSelectionBeginEvent` | 선택 박스 시작 시 텍스트 설정 |
| `View_OnAreaSelectionEndEvent` | 드래그 완료 시 좌표 로그 출력 |

---

## 🎮 단축키 설정

- 기존 `CONTROL_SELECTION_BOX` 단축키 제거
- `Ctrl + Shift + W` 조합으로 **선택 상자 활성화**
- 원하는 조합으로 `Keys.X, true/false, true/false` 설정 변경 가능

```csharp
vizcore3d.Shortcuts.Update(
    Data.ShortcutFunctions.CONTROL_SELECTION_BOX,
    Keys.W,      // W 키
    true,        // Ctrl
    true,        // Shift
    false        // Alt
);
```

## 🧪 이벤트 설명

### 🔹 OnAreaSelectionBeginEvent
- 선택 상자 드래그 시작 시 호출됩니다.
- `e.CustomText`를 통해 커스텀 텍스트 설정이 가능합니다.
- 다국어 대응도 지원하며, `LanguageKind` 기준으로 텍스트 분기 처리할 수 있습니다.

### 🔹 OnAreaSelectionEndEvent
- 드래그 종료 후 마우스 좌표가 제공됩니다.
- `e.BeginPoint`, `e.EndPoint` 값을 활용해 선택 영역의 범위를 확인할 수 있습니다.
- 로그 출력 또는 사용자 정의 상호작용 트리거에 활용 가능합니다.