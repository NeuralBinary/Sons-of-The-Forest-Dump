using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020000D2 RID: 210
	[Token(Token = "0x20000D2")]
	public class FKOffset : MonoBehaviour
	{
		// Token: 0x06000676 RID: 1654 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000676")]
		[Address(RVA = "0x29A1FD0", Offset = "0x29A05D0", VA = "0x1829A1FD0")]
		private void Start()
		{
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000677")]
		[Address(RVA = "0x29A2060", Offset = "0x29A0660", VA = "0x1829A2060")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000678")]
		[Address(RVA = "0x29A2530", Offset = "0x29A0B30", VA = "0x1829A2530")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000679")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public FKOffset()
		{
		}

		// Token: 0x04000606 RID: 1542
		[Token(Token = "0x4000606")]
		[FieldOffset(Offset = "0x20")]
		public FKOffset.Offset[] offsets;

		// Token: 0x04000607 RID: 1543
		[Token(Token = "0x4000607")]
		[FieldOffset(Offset = "0x28")]
		private Animator animator;

		// Token: 0x020000D3 RID: 211
		[Token(Token = "0x20000D3")]
		[Serializable]
		public class Offset
		{
			// Token: 0x0600067A RID: 1658 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600067A")]
			[Address(RVA = "0x29A2640", Offset = "0x29A0C40", VA = "0x1829A2640")]
			public void Apply(Animator animator)
			{
			}

			// Token: 0x0600067B RID: 1659 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600067B")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public Offset()
			{
			}

			// Token: 0x04000608 RID: 1544
			[Token(Token = "0x4000608")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			[HideInInspector]
			public string name;

			// Token: 0x04000609 RID: 1545
			[Token(Token = "0x4000609")]
			[FieldOffset(Offset = "0x18")]
			public HumanBodyBones bone;

			// Token: 0x0400060A RID: 1546
			[Token(Token = "0x400060A")]
			[FieldOffset(Offset = "0x1C")]
			public Vector3 rotationOffset;

			// Token: 0x0400060B RID: 1547
			[Token(Token = "0x400060B")]
			[FieldOffset(Offset = "0x28")]
			private Transform t;
		}
	}
}
