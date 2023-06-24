using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001CD RID: 461
	[Token(Token = "0x20001CD")]
	[AddComponentMenu("Sons/Stimuli/PlayerTarpShelter")]
	public class PlayerTarpShelter : PlayerStructureStimuli
	{
		// Token: 0x06000DB0 RID: 3504 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000DB0")]
		[Address(RVA = "0x2BA6180", Offset = "0x2BA4780", VA = "0x182BA6180")]
		public new static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000DB1")]
		[Address(RVA = "0x2BA61B0", Offset = "0x2BA47B0", VA = "0x182BA61B0")]
		public new static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB2")]
		[Address(RVA = "0x13428C0", Offset = "0x1340EC0", VA = "0x1813428C0")]
		public void Initialize(GameObject tarpObject)
		{
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB3")]
		[Address(RVA = "0x2BA6230", Offset = "0x2BA4830", VA = "0x182BA6230", Slot = "15")]
		public override void OnInteractAnimEvent(VailActor actor, string param)
		{
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB4")]
		[Address(RVA = "0x2B95780", Offset = "0x2B93D80", VA = "0x182B95780")]
		public PlayerTarpShelter()
		{
		}

		// Token: 0x040008C2 RID: 2242
		[Token(Token = "0x40008C2")]
		[FieldOffset(Offset = "0xA8")]
		private GameObject _tarpObject;
	}
}
