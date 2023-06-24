using System;
using Il2CppDummyDll;
using Sons.Save;

namespace Sons.Gui
{
	// Token: 0x02000033 RID: 51
	[Token(Token = "0x2000033")]
	public class NewSlot : SaveSlotBase
	{
		// Token: 0x06000139 RID: 313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x3010EF0", Offset = "0x300F4F0", VA = "0x183010EF0")]
		public void Setup(int slotIndex, Action<int, GameStateData> buttonAction)
		{
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x3010F60", Offset = "0x300F560", VA = "0x183010F60", Slot = "4")]
		internal override void OnButton()
		{
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public NewSlot()
		{
		}

		// Token: 0x0400013A RID: 314
		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x50")]
		private Action<int, GameStateData> _buttonAction;
	}
}
