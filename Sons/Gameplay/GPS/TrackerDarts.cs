using System;
using System.Collections;
using Ballistics;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay.GPS
{
	// Token: 0x0200085C RID: 2140
	[Token(Token = "0x200085C")]
	[AddComponentMenu("Sons/Gameplay/GPS/TrackerDarts")]
	public class TrackerDarts : MonoBehaviour
	{
		// Token: 0x06003D03 RID: 15619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D03")]
		[Address(RVA = "0x35B4DA0", Offset = "0x35B33A0", VA = "0x1835B4DA0")]
		private void Awake()
		{
		}

		// Token: 0x06003D04 RID: 15620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D04")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void Update()
		{
		}

		// Token: 0x06003D05 RID: 15621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D05")]
		[Address(RVA = "0x35B4F10", Offset = "0x35B3510", VA = "0x1835B4F10")]
		private void OnEnable()
		{
		}

		// Token: 0x06003D06 RID: 15622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D06")]
		[Address(RVA = "0x35B53E0", Offset = "0x35B39E0", VA = "0x1835B53E0")]
		private void OnDisable()
		{
		}

		// Token: 0x06003D07 RID: 15623 RVA: 0x00012978 File Offset: 0x00010B78
		[Token(Token = "0x6003D07")]
		[Address(RVA = "0x35B5420", Offset = "0x35B3A20", VA = "0x1835B5420")]
		public Color GetColor()
		{
			return default(Color);
		}

		// Token: 0x06003D08 RID: 15624 RVA: 0x00012990 File Offset: 0x00010B90
		[Token(Token = "0x6003D08")]
		[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000")]
		public int GetColorIndex()
		{
			return 0;
		}

		// Token: 0x06003D09 RID: 15625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D09")]
		[Address(RVA = "0x35B5460", Offset = "0x35B3A60", VA = "0x1835B5460")]
		private void SetTrackerDartColor(int index)
		{
		}

		// Token: 0x06003D0A RID: 15626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D0A")]
		[Address(RVA = "0x35B55B0", Offset = "0x35B3BB0", VA = "0x1835B55B0")]
		public void SetTrackerColorFromOtherState(GameObject objectWithTheColor)
		{
		}

		// Token: 0x06003D0B RID: 15627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D0B")]
		[Address(RVA = "0x35B56D0", Offset = "0x35B3CD0", VA = "0x1835B56D0")]
		public void ActivateTrackerDart()
		{
		}

		// Token: 0x06003D0C RID: 15628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D0C")]
		[Address(RVA = "0x35B5850", Offset = "0x35B3E50", VA = "0x1835B5850")]
		private IEnumerator FlashLight()
		{
			return null;
		}

		// Token: 0x06003D0D RID: 15629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D0D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void OnImpact(ImpactInfo impactInfo)
		{
		}

		// Token: 0x06003D0E RID: 15630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D0E")]
		[Address(RVA = "0x35B58E0", Offset = "0x35B3EE0", VA = "0x1835B58E0")]
		public void OnSurfaceImpact(SurfaceImpactInfo surfaceImpactInfo)
		{
		}

		// Token: 0x06003D0F RID: 15631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D0F")]
		[Address(RVA = "0x35B5C30", Offset = "0x35B4230", VA = "0x1835B5C30")]
		public void StickToTarget(Transform target)
		{
		}

		// Token: 0x06003D10 RID: 15632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D10")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public TrackerDarts()
		{
		}

		// Token: 0x04003396 RID: 13206
		[Token(Token = "0x4003396")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[SerializeField]
		private Color[] _trackingColors;

		// Token: 0x04003397 RID: 13207
		[Token(Token = "0x4003397")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[HideInInspector]
		private int _currentColorIndex;

		// Token: 0x04003398 RID: 13208
		[Token(Token = "0x4003398")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HideInInspector]
		private Rigidbody _rigidbody;

		// Token: 0x04003399 RID: 13209
		[Token(Token = "0x4003399")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		private Light _light;

		// Token: 0x0400339A RID: 13210
		[Token(Token = "0x400339A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _pickUpPrefab;

		// Token: 0x0400339B RID: 13211
		[Token(Token = "0x400339B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _activateImmediately;

		// Token: 0x0400339C RID: 13212
		[Token(Token = "0x400339C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GPSLocator _gpsLocator;

		// Token: 0x0400339D RID: 13213
		[Token(Token = "0x400339D")]
		[FieldOffset(Offset = "0x58")]
		private bool _doneStick;
	}
}
