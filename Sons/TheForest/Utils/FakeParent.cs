using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Utils
{
	// Token: 0x020003AB RID: 939
	[Token(Token = "0x20003AB")]
	public class FakeParent : MonoBehaviour
	{
		// Token: 0x0600192F RID: 6447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600192F")]
		[Address(RVA = "0x328FFD0", Offset = "0x328E5D0", VA = "0x18328FFD0")]
		private void Awake()
		{
		}

		// Token: 0x06001930 RID: 6448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001930")]
		[Address(RVA = "0x32905B0", Offset = "0x328EBB0", VA = "0x1832905B0")]
		private void UpdateCleanupComponent()
		{
		}

		// Token: 0x06001931 RID: 6449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001931")]
		[Address(RVA = "0x3290970", Offset = "0x328EF70", VA = "0x183290970")]
		public void Dispose()
		{
		}

		// Token: 0x06001932 RID: 6450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001932")]
		[Address(RVA = "0x3290A00", Offset = "0x328F000", VA = "0x183290A00")]
		private IEnumerator DelayedAwake()
		{
			return null;
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001933")]
		[Address(RVA = "0x3290A90", Offset = "0x328F090", VA = "0x183290A90")]
		private void OnEnable()
		{
		}

		// Token: 0x06001934 RID: 6452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001934")]
		[Address(RVA = "0x3290C80", Offset = "0x328F280", VA = "0x183290C80")]
		private void OnDisable()
		{
		}

		// Token: 0x06001935 RID: 6453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001935")]
		[Address(RVA = "0x3290F90", Offset = "0x328F590", VA = "0x183290F90")]
		private IEnumerator UnParentRoutine()
		{
			return null;
		}

		// Token: 0x06001936 RID: 6454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001936")]
		[Address(RVA = "0x3291020", Offset = "0x328F620", VA = "0x183291020")]
		public void UnParent()
		{
		}

		// Token: 0x06001937 RID: 6455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001937")]
		[Address(RVA = "0x3291170", Offset = "0x328F770", VA = "0x183291170")]
		public void ReParent()
		{
		}

		// Token: 0x06001938 RID: 6456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001938")]
		[Address(RVA = "0x3291780", Offset = "0x328FD80", VA = "0x183291780")]
		public void SetEulerRotation(Vector3 eulerRotation)
		{
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001939")]
		[Address(RVA = "0x29A29A0", Offset = "0x29A0FA0", VA = "0x1829A29A0")]
		public void SetPosition(Vector3 position)
		{
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600193A")]
		[Address(RVA = "0x62AC90", Offset = "0x629290", VA = "0x18062AC90")]
		public void SetScale(Vector3 scale)
		{
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x0600193B RID: 6459 RVA: 0x00007B78 File Offset: 0x00005D78
		[Token(Token = "0x1700035A")]
		public Vector3 RealPosition
		{
			[Token(Token = "0x600193B")]
			[Address(RVA = "0x3291840", Offset = "0x328FE40", VA = "0x183291840")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x0600193C RID: 6460 RVA: 0x00007B90 File Offset: 0x00005D90
		[Token(Token = "0x1700035B")]
		public Quaternion RealRotation
		{
			[Token(Token = "0x600193C")]
			[Address(RVA = "0x3291AE0", Offset = "0x32900E0", VA = "0x183291AE0")]
			get
			{
				return default(Quaternion);
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x0600193D RID: 6461 RVA: 0x00007BA8 File Offset: 0x00005DA8
		[Token(Token = "0x1700035C")]
		public Vector3 RealLocalPosition
		{
			[Token(Token = "0x600193D")]
			[Address(RVA = "0x29A2980", Offset = "0x29A0F80", VA = "0x1829A2980")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x0600193E RID: 6462 RVA: 0x00007BC0 File Offset: 0x00005DC0
		[Token(Token = "0x1700035D")]
		public Quaternion RealLocalRotation
		{
			[Token(Token = "0x600193E")]
			[Address(RVA = "0x2B88D90", Offset = "0x2B87390", VA = "0x182B88D90")]
			get
			{
				return default(Quaternion);
			}
		}

		// Token: 0x0600193F RID: 6463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600193F")]
		[Address(RVA = "0x3291DE0", Offset = "0x32903E0", VA = "0x183291DE0")]
		public FakeParent()
		{
		}

		// Token: 0x040018BE RID: 6334
		[Token(Token = "0x40018BE")]
		[FieldOffset(Offset = "0x20")]
		public bool disableOnAwake;

		// Token: 0x040018BF RID: 6335
		[Token(Token = "0x40018BF")]
		[FieldOffset(Offset = "0x21")]
		public bool ignoreWeaponPositionFix;

		// Token: 0x040018C0 RID: 6336
		[Token(Token = "0x40018C0")]
		[FieldOffset(Offset = "0x22")]
		public bool useScale;

		// Token: 0x040018C1 RID: 6337
		[Token(Token = "0x40018C1")]
		[FieldOffset(Offset = "0x24")]
		private Vector3 _pos;

		// Token: 0x040018C2 RID: 6338
		[Token(Token = "0x40018C2")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 _scale;

		// Token: 0x040018C3 RID: 6339
		[Token(Token = "0x40018C3")]
		[FieldOffset(Offset = "0x3C")]
		private Quaternion _rot;

		// Token: 0x040018C4 RID: 6340
		[Token(Token = "0x40018C4")]
		[FieldOffset(Offset = "0x4C")]
		private float timer;

		// Token: 0x040018C5 RID: 6341
		[Token(Token = "0x40018C5")]
		[FieldOffset(Offset = "0x50")]
		private Transform _target;
	}
}
