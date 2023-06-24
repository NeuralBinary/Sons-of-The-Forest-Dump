using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Areas
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	[AddComponentMenu("Sons/World/Area Changed Event")]
	public class AreaChangeEvent : MonoBehaviour
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2D262C0", Offset = "0x2D248C0", VA = "0x182D262C0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2D263A0", Offset = "0x2D249A0", VA = "0x182D263A0")]
		private void OnDisable()
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2D26410", Offset = "0x2D24A10", VA = "0x182D26410")]
		private bool IsAreaEnter(AreaMask oldMask, AreaMask newMask)
		{
			return default(bool);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002080 File Offset: 0x00000280
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2D26430", Offset = "0x2D24A30", VA = "0x182D26430")]
		private bool IsAreaExit(AreaMask oldMask, AreaMask newMask)
		{
			return default(bool);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2D26450", Offset = "0x2D24A50", VA = "0x182D26450")]
		private void OnCaveChanged(AreaMask oldMask, AreaMask newMask, PlayerType playerType)
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x2D26570", Offset = "0x2D24B70", VA = "0x182D26570")]
		private void OnCaveChangedAll(AreaMask oldMask, AreaMask newMask)
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2D265D0", Offset = "0x2D24BD0", VA = "0x182D265D0")]
		private void OnCaveChangedLocal(AreaMask oldMask, AreaMask newMask)
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public AreaChangeEvent()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UnityEvent _onAreaEnterAll;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UnityEvent _onAreaExitAll;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UnityEvent _onAreaChangedAll;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UnityEvent _onAreaEnterLocal;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UnityEvent _onAreaExitLocal;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UnityEvent _onAreaChangedLocal;
	}
}
