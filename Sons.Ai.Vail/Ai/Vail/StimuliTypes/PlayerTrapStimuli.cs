using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001CE RID: 462
	[Token(Token = "0x20001CE")]
	[AddComponentMenu("Sons/Stimuli/PlayerTrapStimuli")]
	public class PlayerTrapStimuli : PlayerStructureStimuli
	{
		// Token: 0x06000DB5 RID: 3509 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000DB5")]
		[Address(RVA = "0x2BA64B0", Offset = "0x2BA4AB0", VA = "0x182BA64B0")]
		public new static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000DB6")]
		[Address(RVA = "0x2BA64E0", Offset = "0x2BA4AE0", VA = "0x182BA64E0")]
		public new static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB7")]
		[Address(RVA = "0x2BA6560", Offset = "0x2BA4B60", VA = "0x182BA6560", Slot = "15")]
		public override void OnInteractAnimEvent(VailActor actor, string param)
		{
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x00007D10 File Offset: 0x00005F10
		[Token(Token = "0x6000DB8")]
		[Address(RVA = "0x2BA6660", Offset = "0x2BA4C60", VA = "0x182BA6660", Slot = "12")]
		public override bool Validate(VailActor actor)
		{
			return default(bool);
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB9")]
		[Address(RVA = "0x12433E0", Offset = "0x12419E0", VA = "0x1812433E0")]
		public void SetTrapIsReady(bool isReady)
		{
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DBA")]
		[Address(RVA = "0x2BA6770", Offset = "0x2BA4D70", VA = "0x182BA6770")]
		public void ResetTrap()
		{
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DBB")]
		[Address(RVA = "0x2B95780", Offset = "0x2B93D80", VA = "0x182B95780")]
		public PlayerTrapStimuli()
		{
		}

		// Token: 0x040008C3 RID: 2243
		[Token(Token = "0x40008C3")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UnityEvent _resetAction;

		// Token: 0x040008C4 RID: 2244
		[Token(Token = "0x40008C4")]
		[FieldOffset(Offset = "0xB0")]
		private bool _trapIsReady;
	}
}
