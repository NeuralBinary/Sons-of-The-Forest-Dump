using System;
using Il2CppDummyDll;
using Sons.Gui.Input;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000213 RID: 531
	[Token(Token = "0x2000213")]
	[AddComponentMenu("Sons/Construction/ShutterLock")]
	public class ShutterLock : SwitchStateBase
	{
		// Token: 0x06000FE7 RID: 4071 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FE7")]
		[Address(RVA = "0x2F082F0", Offset = "0x2F068F0", VA = "0x182F082F0")]
		private void Update()
		{
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FE8")]
		[Address(RVA = "0x2F08540", Offset = "0x2F06B40", VA = "0x182F08540", Slot = "6")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FE9")]
		[Address(RVA = "0x2F08600", Offset = "0x2F06C00", VA = "0x182F08600", Slot = "7")]
		public override void SwitchState(Vector3 playerPosition)
		{
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FEA")]
		[Address(RVA = "0x2F08630", Offset = "0x2F06C30", VA = "0x182F08630")]
		public void SwitchClosedState(Vector3 playerPosition)
		{
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x00009A4C File Offset: 0x00007C4C
		[Token(Token = "0x6000FEB")]
		[Address(RVA = "0x2F08B00", Offset = "0x2F07100", VA = "0x182F08B00")]
		private bool IsInFront(Vector3 playerPosition)
		{
			return default(bool);
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FEC")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ShutterLock()
		{
		}

		// Token: 0x0400086B RID: 2155
		[Token(Token = "0x400086B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LinkUiElement _forwardIcon;

		// Token: 0x0400086C RID: 2156
		[Token(Token = "0x400086C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LinkUiElement _backIcon;

		// Token: 0x0400086D RID: 2157
		[Token(Token = "0x400086D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ElementProfile _switchTo;

		// Token: 0x0400086E RID: 2158
		[Token(Token = "0x400086E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AudioClipProfile _sfx;
	}
}
