using System;
using Il2CppDummyDll;
using NGUI.Internal;
using UnityEngine;

namespace NGUI
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	[RequireComponent(typeof(UIWidget))]
	[AddComponentMenu("NGUI/Examples/Envelop Content")]
	public class EnvelopContent : MonoBehaviour
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x260F9C0", Offset = "0x260DFC0", VA = "0x18260F9C0")]
		private void Start()
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x260F9D0", Offset = "0x260DFD0", VA = "0x18260F9D0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x260F9E0", Offset = "0x260DFE0", VA = "0x18260F9E0")]
		private void Update()
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x260FB10", Offset = "0x260E110", VA = "0x18260FB10")]
		private void UpdateInactive()
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x260FCE0", Offset = "0x260E2E0", VA = "0x18260FCE0")]
		[ContextMenu("Execute")]
		public void Execute()
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000206C File Offset: 0x0000026C
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2610040", Offset = "0x260E640", VA = "0x182610040")]
		private bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public EnvelopContent()
		{
		}

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x20")]
		public Transform targetRoot;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x28")]
		public int padLeft;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x2C")]
		public int padRight;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x30")]
		public int padBottom;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x34")]
		public int padTop;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x38")]
		private bool mStarted;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x40")]
		private UIWidget _uiWidget;
	}
}
