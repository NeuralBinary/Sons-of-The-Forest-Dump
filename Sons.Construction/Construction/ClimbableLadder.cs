using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020001C4 RID: 452
	[Token(Token = "0x20001C4")]
	[AddComponentMenu("Sons/Construction/ClimbableLadder")]
	public class ClimbableLadder : MonoBehaviour
	{
		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000D46 RID: 3398 RVA: 0x000083B4 File Offset: 0x000065B4
		// (set) Token: 0x06000D47 RID: 3399 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000328")]
		public bool AutoClimbOnForward
		{
			[Token(Token = "0x6000D46")]
			[Address(RVA = "0x642350", Offset = "0x640950", VA = "0x180642350")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D47")]
			[Address(RVA = "0x7AAFD0", Offset = "0x7A95D0", VA = "0x1807AAFD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000D48 RID: 3400 RVA: 0x000083CC File Offset: 0x000065CC
		// (set) Token: 0x06000D49 RID: 3401 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000329")]
		public bool Animate
		{
			[Token(Token = "0x6000D48")]
			[Address(RVA = "0x9938E0", Offset = "0x991EE0", VA = "0x1809938E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D49")]
			[Address(RVA = "0x9C5820", Offset = "0x9C3E20", VA = "0x1809C5820")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000D4A RID: 3402 RVA: 0x000083E4 File Offset: 0x000065E4
		// (set) Token: 0x06000D4B RID: 3403 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700032A")]
		public bool FixedPosition
		{
			[Token(Token = "0x6000D4A")]
			[Address(RVA = "0x993970", Offset = "0x991F70", VA = "0x180993970")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D4B")]
			[Address(RVA = "0x2B66130", Offset = "0x2B64730", VA = "0x182B66130")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000D4C RID: 3404 RVA: 0x000083FC File Offset: 0x000065FC
		// (set) Token: 0x06000D4D RID: 3405 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700032B")]
		public Vector3 LadderAxis
		{
			[Token(Token = "0x6000D4C")]
			[Address(RVA = "0x29A2980", Offset = "0x29A0F80", VA = "0x1829A2980")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000D4D")]
			[Address(RVA = "0x29A29A0", Offset = "0x29A0FA0", VA = "0x1829A29A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D4E")]
		[Address(RVA = "0x2ECD520", Offset = "0x2ECBB20", VA = "0x182ECD520")]
		private void OnTriggerEnter(Collider c)
		{
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D4F")]
		[Address(RVA = "0x2ECD6E0", Offset = "0x2ECBCE0", VA = "0x182ECD6E0")]
		private void OnTriggerExit(Collider c)
		{
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x00008414 File Offset: 0x00006614
		[Token(Token = "0x6000D50")]
		[Address(RVA = "0x2ECD7F0", Offset = "0x2ECBDF0", VA = "0x182ECD7F0")]
		internal Vector3 CalcExitAtTopPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D51")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ClimbableLadder()
		{
		}
	}
}
