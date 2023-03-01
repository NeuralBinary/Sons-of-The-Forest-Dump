using System;
using System.Collections;
using Ballistics;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay.GPS
{
	// Token: 0x0200070E RID: 1806
	[Token(Token = "0x200070E")]
	[AddComponentMenu("Sons/Gameplay/GPS/TrackerDarts")]
	public class TrackerDarts : MonoBehaviour
	{
		// Token: 0x06002F07 RID: 12039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F07")]
		[Address(RVA = "0x2E38790", Offset = "0x2E37790", VA = "0x182E38790")]
		private void Awake()
		{
		}

		// Token: 0x06002F08 RID: 12040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F08")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		private void Update()
		{
		}

		// Token: 0x06002F09 RID: 12041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F09")]
		[Address(RVA = "0x2E38960", Offset = "0x2E37960", VA = "0x182E38960")]
		private void OnEnable()
		{
		}

		// Token: 0x06002F0A RID: 12042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F0A")]
		[Address(RVA = "0x2E38920", Offset = "0x2E37920", VA = "0x182E38920")]
		private void OnDisable()
		{
		}

		// Token: 0x06002F0B RID: 12043 RVA: 0x0000D6B0 File Offset: 0x0000B8B0
		[Token(Token = "0x6002F0B")]
		[Address(RVA = "0x2E388E0", Offset = "0x2E378E0", VA = "0x182E388E0")]
		public Color GetColor()
		{
			return default(Color);
		}

		// Token: 0x06002F0C RID: 12044 RVA: 0x0000D6C8 File Offset: 0x0000B8C8
		[Token(Token = "0x6002F0C")]
		[Address(RVA = "0x589ED0", Offset = "0x588ED0", VA = "0x180589ED0")]
		public int GetColorIndex()
		{
			return default(int);
		}

		// Token: 0x06002F0D RID: 12045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F0D")]
		[Address(RVA = "0x2E38F40", Offset = "0x2E37F40", VA = "0x182E38F40")]
		private void SetTrackerDartColor(int index)
		{
		}

		// Token: 0x06002F0E RID: 12046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F0E")]
		[Address(RVA = "0x2E38EA0", Offset = "0x2E37EA0", VA = "0x182E38EA0")]
		public void SetTrackerColorFromOtherState(GameObject objectWithTheColor)
		{
		}

		// Token: 0x06002F0F RID: 12047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F0F")]
		[Address(RVA = "0x2E386A0", Offset = "0x2E376A0", VA = "0x182E386A0")]
		public void ActivateTrackerDart()
		{
		}

		// Token: 0x06002F10 RID: 12048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F10")]
		[Address(RVA = "0x2E38870", Offset = "0x2E37870", VA = "0x182E38870")]
		private IEnumerator FlashLight()
		{
			return null;
		}

		// Token: 0x06002F11 RID: 12049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F11")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		public void OnImpact(ImpactInfo impactInfo)
		{
		}

		// Token: 0x06002F12 RID: 12050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F12")]
		[Address(RVA = "0x2E38BA0", Offset = "0x2E37BA0", VA = "0x182E38BA0")]
		public void OnSurfaceImpact(SurfaceImpactInfo surfaceImpactInfo)
		{
		}

		// Token: 0x06002F13 RID: 12051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F13")]
		[Address(RVA = "0x2E39000", Offset = "0x2E38000", VA = "0x182E39000")]
		public void StickToTarget(Transform target)
		{
		}

		// Token: 0x06002F14 RID: 12052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F14")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public TrackerDarts()
		{
		}

		// Token: 0x040029AC RID: 10668
		[Token(Token = "0x40029AC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		private Color[] _trackingColors;

		// Token: 0x040029AD RID: 10669
		[Token(Token = "0x40029AD")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		[SerializeField]
		private int _currentColorIndex;

		// Token: 0x040029AE RID: 10670
		[Token(Token = "0x40029AE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HideInInspector]
		private Rigidbody _rigidbody;

		// Token: 0x040029AF RID: 10671
		[Token(Token = "0x40029AF")]
		[FieldOffset(Offset = "0x38")]
		[HideInInspector]
		[SerializeField]
		private Light _light;

		// Token: 0x040029B0 RID: 10672
		[Token(Token = "0x40029B0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _pickUpPrefab;

		// Token: 0x040029B1 RID: 10673
		[Token(Token = "0x40029B1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _activateImmediately;

		// Token: 0x040029B2 RID: 10674
		[Token(Token = "0x40029B2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GPSLocator _gpsLocator;

		// Token: 0x040029B3 RID: 10675
		[Token(Token = "0x40029B3")]
		[FieldOffset(Offset = "0x58")]
		private bool _doneStick;
	}
}
