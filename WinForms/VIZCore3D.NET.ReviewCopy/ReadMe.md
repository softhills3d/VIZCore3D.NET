# VIZCore3D.NET.ReviewCopy

**VIZCore3D.NET.ReviewCopy**는 VIZCore3D.NET 엔진을 기반으로 사용자가 작성한 리뷰 노트(Review Note)를 다른 지점에 복사할 수 있도록 도와주는 WinForms 기반 데모 애플리케이션입니다.

---

## 🔧 주요 기능

- VIZCore3D.NET 초기화 및 라이선스 연동
- 리뷰(Review) 항목 추가 및 자동 분류 (`Note`, 기타)
- `DataGridView`를 통해 리뷰 목록 확인
- 선택된 리뷰의 3D 좌표 피킹 기능
- 선택된 리뷰를 다른 지점에 **복사(AddNoteX)**

---

## 🧩 구성 요소 설명

### 1. `vizcore3d`  
- VIZCore3D 컨트롤 인스턴스
- Dock 방식으로 화면에 삽입됨

### 2. `dataGridView1`
- 추가된 리뷰 목록을 보여주는 UI 컨트롤
- `"아이디(ID)"`, `"타입(Type)"` 컬럼 표시
- 행 선택 시 복사 대상 리뷰 ID 저장

### 3. 이벤트 핸들링
- `Review_OnReviewChangedEvent`: 리뷰 생성 시 DataGridView에 자동 추가
- `GeometryUtility_OnOsnapPickingItem`: 피킹된 위치에 노트 복사 생성
- `button1_Click`: 선택된 리뷰를 피킹할 수 있도록 기능 활성화

---

## ▶ 실행 방법

1. `VIZCore3D.NET` 라이브러리 참조 필요
   - 라이선스 서버 주소: `127.0.0.1`, 포트: `8901`
2. Visual Studio에서 실행 (WinForms 앱)
3. 리뷰 작성 후 `DataGridView`에서 복사할 리뷰 선택 → [복사] 버튼 클릭
4. 모델에서 새로운 위치 클릭 → 리뷰가 복제됨