using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x02000180 RID: 384
	[Token(Token = "0x2000180")]
	[AddComponentMenu("Sons/Stimuli/Bed Stimuli")]
	public class BedStimuli : AffectOverTimeStimuli
	{
		// Token: 0x06000C17 RID: 3095 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000C17")]
		[Address(RVA = "0x2B97B20", Offset = "0x2B96120", VA = "0x182B97B20")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000C18")]
		[Address(RVA = "0x2B97B50", Offset = "0x2B96150", VA = "0x182B97B50")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x000073C8 File Offset: 0x000055C8
		[Token(Token = "0x6000C19")]
		[Address(RVA = "0x67D850", Offset = "0x67BE50", VA = "0x18067D850")]
		public static int GridType()
		{
			return 0;
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C1A")]
		[Address(RVA = "0x2B97BD0", Offset = "0x2B961D0", VA = "0x182B97BD0")]
		private BedStimuli()
		{
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C1B")]
		[Address(RVA = "0xAFF390", Offset = "0xAFD990", VA = "0x180AFF390")]
		public void SetOwner(int ownerId)
		{
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x000073E0 File Offset: 0x000055E0
		[Token(Token = "0x6000C1C")]
		[Address(RVA = "0x2B97C20", Offset = "0x2B96220", VA = "0x182B97C20", Slot = "12")]
		public override bool Validate(VailActor vailActor)
		{
			return default(bool);
		}

		// Token: 0x04000849 RID: 2121
		[Token(Token = "0x4000849")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private bool _checkOwner;

		// Token: 0x0400084A RID: 2122
		[Token(Token = "0x400084A")]
		[FieldOffset(Offset = "0xB4")]
		private int _ownerUniqueId;
	}
}
