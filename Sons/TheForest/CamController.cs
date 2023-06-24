using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace TheForest
{
	// Token: 0x02000355 RID: 853
	[Token(Token = "0x2000355")]
	[AddComponentMenu("TheForest/CamController")]
	public class CamController : MonoBehaviour
	{
		// Token: 0x06001554 RID: 5460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001554")]
		[Address(RVA = "0x326F480", Offset = "0x326DA80", VA = "0x18326F480")]
		public void SetEnabled(CamController.CameraId cameraId, bool activeValue)
		{
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001555")]
		[Address(RVA = "0x326F9E0", Offset = "0x326DFE0", VA = "0x18326F9E0")]
		private void DisableCamera(CamController.CameraId cameraId)
		{
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001556")]
		[Address(RVA = "0x326FA80", Offset = "0x326E080", VA = "0x18326FA80")]
		private void SetEnabledInt(bool activeValue, params GameObject[] cameras)
		{
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x00007050 File Offset: 0x00005250
		[Token(Token = "0x6001557")]
		[Address(RVA = "0x326FBA0", Offset = "0x326E1A0", VA = "0x18326FBA0")]
		public bool IsActive(CamController.CameraId cameraId)
		{
			return default(bool);
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001558")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public CamController()
		{
		}

		// Token: 0x040015DD RID: 5597
		[Token(Token = "0x40015DD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _playerCamera;

		// Token: 0x040015DE RID: 5598
		[Token(Token = "0x40015DE")]
		[FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("SleepCam")]
		[SerializeField]
		private GameObject _sleepCam;

		// Token: 0x040015DF RID: 5599
		[Token(Token = "0x40015DF")]
		[FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("PedometerCam")]
		[SerializeField]
		private GameObject _pedometerCam;

		// Token: 0x040015E0 RID: 5600
		[Token(Token = "0x40015E0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[FormerlySerializedAs("SaveCam")]
		private GameObject _saveCam;

		// Token: 0x02000356 RID: 854
		[Token(Token = "0x2000356")]
		[Serializable]
		public enum CameraId
		{
			// Token: 0x040015E2 RID: 5602
			[Token(Token = "0x40015E2")]
			Player,
			// Token: 0x040015E3 RID: 5603
			[Token(Token = "0x40015E3")]
			Sleep,
			// Token: 0x040015E4 RID: 5604
			[Token(Token = "0x40015E4")]
			CaveDead,
			// Token: 0x040015E5 RID: 5605
			[Token(Token = "0x40015E5")]
			Dead,
			// Token: 0x040015E6 RID: 5606
			[Token(Token = "0x40015E6")]
			Pedometer,
			// Token: 0x040015E7 RID: 5607
			[Token(Token = "0x40015E7")]
			Save
		}
	}
}
