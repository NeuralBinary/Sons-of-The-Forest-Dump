using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction.Multiplayer
{
	// Token: 0x02000299 RID: 665
	[Token(Token = "0x2000299")]
	[AddComponentMenu("Sons/Construction/RemotelyAnticipatedStructures")]
	public class RemotelyAnticipatedStructures : MonoBehaviour
	{
		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06001439 RID: 5177 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x0600143A RID: 5178 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700043C")]
		public string PlayerName
		{
			[Token(Token = "0x6001439")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600143A")]
			[Address(RVA = "0x5B2560", Offset = "0x5B0B60", VA = "0x1805B2560")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600143B")]
		[Address(RVA = "0x2DEDAE0", Offset = "0x2DEC0E0", VA = "0x182DEDAE0")]
		private void Update()
		{
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x0000BF0C File Offset: 0x0000A10C
		[Token(Token = "0x600143C")]
		[Address(RVA = "0x2DEDB40", Offset = "0x2DEC140", VA = "0x182DEDB40")]
		public bool TryFindAnticipatedStructure(int placeActionNum, int typeId, out Structure structure)
		{
			return default(bool);
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600143D")]
		[Address(RVA = "0x2DEDE70", Offset = "0x2DEC470", VA = "0x182DEDE70")]
		private void CheckForOldActionsToCleanUp()
		{
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600143E")]
		[Address(RVA = "0x2DEE000", Offset = "0x2DEC600", VA = "0x182DEE000")]
		public void BeginPlace(int placeActionNum)
		{
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600143F")]
		[Address(RVA = "0x2DEE1F0", Offset = "0x2DEC7F0", VA = "0x182DEE1F0")]
		public void FinishPlace()
		{
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001440")]
		[Address(RVA = "0x2DEE250", Offset = "0x2DEC850", VA = "0x182DEE250")]
		private void BeginRegisterAnticipatedStructure()
		{
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001441")]
		[Address(RVA = "0x2DEE1F0", Offset = "0x2DEC7F0", VA = "0x182DEE1F0")]
		private void StopRegisterAnticipatedStructure()
		{
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001442")]
		[Address(RVA = "0x2DEE350", Offset = "0x2DEC950", VA = "0x182DEE350")]
		private void RegisterStructureCreated(Structure structure)
		{
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001443")]
		[Address(RVA = "0x2DEE360", Offset = "0x2DEC960", VA = "0x182DEE360")]
		private void RegisterStructureCreated(int placeActionNum, Structure structure)
		{
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001444")]
		[Address(RVA = "0x2DEE610", Offset = "0x2DECC10", VA = "0x182DEE610")]
		public RemotelyAnticipatedStructures()
		{
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001445")]
		[Address(RVA = "0x2DEE6F0", Offset = "0x2DECCF0", VA = "0x182DEE6F0")]
		[CompilerGenerated]
		private void <TryFindAnticipatedStructure>g__LogFailure|10_0(ref RemotelyAnticipatedStructures.<>c__DisplayClass10_0 A_1)
		{
		}

		// Token: 0x040009D2 RID: 2514
		[Token(Token = "0x40009D2")]
		[FieldOffset(Offset = "0x20")]
		private int _oldestActionNum;

		// Token: 0x040009D3 RID: 2515
		[Token(Token = "0x40009D3")]
		[FieldOffset(Offset = "0x24")]
		private int _latestActionNum;

		// Token: 0x040009D4 RID: 2516
		[Token(Token = "0x40009D4")]
		[FieldOffset(Offset = "0x28")]
		private int _pendingPlaceActionNum;

		// Token: 0x040009D5 RID: 2517
		[Token(Token = "0x40009D5")]
		[FieldOffset(Offset = "0x30")]
		private readonly Dictionary<int, List<Structure>> _anticipatedStructures;

		// Token: 0x040009D6 RID: 2518
		[Token(Token = "0x40009D6")]
		[FieldOffset(Offset = "0x38")]
		private Action<Structure> _registerStructureCreatedCallback;
	}
}
