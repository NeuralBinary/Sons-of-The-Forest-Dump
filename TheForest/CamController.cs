using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace TheForest
{
	// Token: 0x02000363 RID: 867
	[Token(Token = "0x2000363")]
	[AddComponentMenu("TheForest/CamController")]
	public class CamController : MonoBehaviour
	{
		// Token: 0x06001529 RID: 5417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001529")]
		[Address(RVA = "0x2CAE160", Offset = "0x2CAD160", VA = "0x182CAE160")]
		public void SetEnabled(CamController.CameraId cameraId, bool activeValue)
		{
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600152A")]
		[Address(RVA = "0x2CADD70", Offset = "0x2CACD70", VA = "0x182CADD70")]
		private void DisableCamera(CamController.CameraId cameraId)
		{
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600152B")]
		[Address(RVA = "0x2CAE0A0", Offset = "0x2CAD0A0", VA = "0x182CAE0A0")]
		private void SetEnabledInt(bool activeValue, params GameObject[] cameras)
		{
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x00006E10 File Offset: 0x00005010
		[Token(Token = "0x600152C")]
		[Address(RVA = "0x2CADF40", Offset = "0x2CACF40", VA = "0x182CADF40")]
		public bool IsActive(CamController.CameraId cameraId)
		{
			return default(bool);
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600152D")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public CamController()
		{
		}

		// Token: 0x040015BF RID: 5567
		[Token(Token = "0x40015BF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _playerCamera;

		// Token: 0x040015C0 RID: 5568
		[Token(Token = "0x40015C0")]
		[FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("SleepCam")]
		[SerializeField]
		private GameObject _sleepCam;

		// Token: 0x040015C1 RID: 5569
		[Token(Token = "0x40015C1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[FormerlySerializedAs("PedometerCam")]
		private GameObject _pedometerCam;

		// Token: 0x040015C2 RID: 5570
		[Token(Token = "0x40015C2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[FormerlySerializedAs("SaveCam")]
		private GameObject _saveCam;

		// Token: 0x02000364 RID: 868
		[Token(Token = "0x2000364")]
		[Serializable]
		public enum CameraId
		{
			// Token: 0x040015C4 RID: 5572
			[Token(Token = "0x40015C4")]
			Player,
			// Token: 0x040015C5 RID: 5573
			[Token(Token = "0x40015C5")]
			Sleep,
			// Token: 0x040015C6 RID: 5574
			[Token(Token = "0x40015C6")]
			CaveDead,
			// Token: 0x040015C7 RID: 5575
			[Token(Token = "0x40015C7")]
			Dead,
			// Token: 0x040015C8 RID: 5576
			[Token(Token = "0x40015C8")]
			Pedometer,
			// Token: 0x040015C9 RID: 5577
			[Token(Token = "0x40015C9")]
			Save
		}
	}
}
