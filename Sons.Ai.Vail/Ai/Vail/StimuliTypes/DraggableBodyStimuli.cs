using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x02000197 RID: 407
	[Token(Token = "0x2000197")]
	[AddComponentMenu("Sons/Stimuli/Drag Body Stimuli")]
	public class DraggableBodyStimuli : InteractStimuli
	{
		// Token: 0x06000C93 RID: 3219 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000C93")]
		[Address(RVA = "0x2B9C830", Offset = "0x2B9AE30", VA = "0x182B9C830")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000C94")]
		[Address(RVA = "0x2B9C860", Offset = "0x2B9AE60", VA = "0x182B9C860")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C95")]
		[Address(RVA = "0x2B9C8E0", Offset = "0x2B9AEE0", VA = "0x182B9C8E0")]
		public void OnAttach(VailActor vailActor)
		{
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x00007590 File Offset: 0x00005790
		[Token(Token = "0x6000C96")]
		[Address(RVA = "0x2B9CA00", Offset = "0x2B9B000", VA = "0x182B9CA00", Slot = "11")]
		public override bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C97")]
		[Address(RVA = "0x2B955D0", Offset = "0x2B93BD0", VA = "0x182B955D0")]
		public DraggableBodyStimuli()
		{
		}
	}
}
