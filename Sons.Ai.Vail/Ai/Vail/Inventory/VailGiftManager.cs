using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Ai.Vail.Memory;
using UnityEngine;

namespace Sons.Ai.Vail.Inventory
{
	// Token: 0x02000221 RID: 545
	[Token(Token = "0x2000221")]
	public class VailGiftManager : MonoBehaviour
	{
		// Token: 0x06000F76 RID: 3958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F76")]
		[Address(RVA = "0x2BBE130", Offset = "0x2BBC730", VA = "0x182BBE130")]
		private void OnValidate()
		{
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F77")]
		[Address(RVA = "0x2BBE260", Offset = "0x2BBC860", VA = "0x182BBE260")]
		public void OnSeePlayer(MonoBehaviourStimuli targetStimuli)
		{
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F78")]
		[Address(RVA = "0x2BBE320", Offset = "0x2BBC920", VA = "0x182BBE320")]
		public void OnMemoryEvent(MonoBehaviourStimuli targetStimuli, MemoryEvent type, int count)
		{
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F79")]
		[Address(RVA = "0x2BBE470", Offset = "0x2BBCA70", VA = "0x182BBE470")]
		private void ChooseGiftToCarry()
		{
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F7A")]
		[Address(RVA = "0x2BBE600", Offset = "0x2BBCC00", VA = "0x182BBE600")]
		public void InstantCarry(string itemName)
		{
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x00008748 File Offset: 0x00006948
		[Token(Token = "0x6000F7B")]
		[Address(RVA = "0x2BBE670", Offset = "0x2BBCC70", VA = "0x182BBE670")]
		private bool IsInNearPlayerView()
		{
			return default(bool);
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F7C")]
		[Address(RVA = "0x2BBE710", Offset = "0x2BBCD10", VA = "0x182BBE710")]
		private void Update()
		{
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F7D")]
		[Address(RVA = "0x2BBE850", Offset = "0x2BBCE50", VA = "0x182BBE850")]
		public void OnConvertToRealActor()
		{
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x00008760 File Offset: 0x00006960
		[Token(Token = "0x6000F7E")]
		[Address(RVA = "0x2BBE880", Offset = "0x2BBCE80", VA = "0x182BBE880")]
		private float GetPlayerSentiment()
		{
			return 0f;
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F7F")]
		[Address(RVA = "0x2BBEAB0", Offset = "0x2BBD0B0", VA = "0x182BBEAB0")]
		public void OnDropItem()
		{
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F80")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public VailGiftManager()
		{
		}

		// Token: 0x04000962 RID: 2402
		[Token(Token = "0x4000962")]
		private const float GiftCheckTick = 2f;

		// Token: 0x04000963 RID: 2403
		[Token(Token = "0x4000963")]
		private const float GiftMinPlayerDistance = 30f;

		// Token: 0x04000964 RID: 2404
		[Token(Token = "0x4000964")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private VailGiftData _giftData;

		// Token: 0x04000965 RID: 2405
		[Token(Token = "0x4000965")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private VailActor _actor;

		// Token: 0x04000966 RID: 2406
		[Token(Token = "0x4000966")]
		[FieldOffset(Offset = "0x30")]
		private float _nextGiftCheckTime;

		// Token: 0x04000967 RID: 2407
		[Token(Token = "0x4000967")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<Type> PlayerTypeList;
	}
}
