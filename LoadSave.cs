using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200029F RID: 671
[Token(Token = "0x200029F")]
[Obsolete]
public class LoadSave : MonoBehaviour
{
	// Token: 0x1400000D RID: 13
	// (add) Token: 0x06001150 RID: 4432 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x06001151 RID: 4433 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1400000D")]
	public static event Action OnGameStart
	{
		[Token(Token = "0x6001150")]
		[Address(RVA = "0x2FB5420", Offset = "0x2FB4420", VA = "0x182FB5420")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6001151")]
		[Address(RVA = "0x2FB54E0", Offset = "0x2FB44E0", VA = "0x182FB54E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x06001152 RID: 4434 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001152")]
	[Address(RVA = "0x2FB4F90", Offset = "0x2FB3F90", VA = "0x182FB4F90")]
	private void Awake()
	{
	}

	// Token: 0x06001153 RID: 4435 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001153")]
	[Address(RVA = "0x2FB53E0", Offset = "0x2FB43E0", VA = "0x182FB53E0")]
	private void Start()
	{
	}

	// Token: 0x06001154 RID: 4436 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001154")]
	[Address(RVA = "0x2FB5130", Offset = "0x2FB4130", VA = "0x182FB5130")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001155 RID: 4437 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001155")]
	[Address(RVA = "0x2FB5180", Offset = "0x2FB4180", VA = "0x182FB5180")]
	private void OnDisable()
	{
	}

	// Token: 0x06001156 RID: 4438 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001156")]
	[Address(RVA = "0x2FB4F10", Offset = "0x2FB3F10", VA = "0x182FB4F10")]
	public IEnumerator Activation(bool activate)
	{
		return null;
	}

	// Token: 0x06001157 RID: 4439 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001157")]
	[Address(RVA = "0x2FB5320", Offset = "0x2FB4320", VA = "0x182FB5320")]
	private void SetStartSequenceStep(int step, float stepAlpha = 1f)
	{
	}

	// Token: 0x06001158 RID: 4440 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001158")]
	[Address(RVA = "0x2FB5220", Offset = "0x2FB4220", VA = "0x182FB5220")]
	public void OnSaveSlotSelected()
	{
	}

	// Token: 0x06001159 RID: 4441 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001159")]
	[Address(RVA = "0x2FB51D0", Offset = "0x2FB41D0", VA = "0x182FB51D0")]
	private IEnumerator OnSaveSlotSelectedRoutine()
	{
		return null;
	}

	// Token: 0x0600115A RID: 4442 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600115A")]
	[Address(RVA = "0x2FB52D0", Offset = "0x2FB42D0", VA = "0x182FB52D0")]
	public void OnSaveSlotSelectionCanceled()
	{
	}

	// Token: 0x0600115B RID: 4443 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600115B")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public LoadSave()
	{
	}

	// Token: 0x04001127 RID: 4391
	[Token(Token = "0x4001127")]
	[FieldOffset(Offset = "0x20")]
	public List<LoadSave.GameObjectList> _activateAfterLoading;

	// Token: 0x04001128 RID: 4392
	[Token(Token = "0x4001128")]
	[FieldOffset(Offset = "0x28")]
	private bool startedSequence;

	// Token: 0x020002A0 RID: 672
	[Token(Token = "0x20002A0")]
	[Serializable]
	public class GameObjectList
	{
		// Token: 0x0600115C RID: 4444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600115C")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		public GameObjectList()
		{
		}

		// Token: 0x04001129 RID: 4393
		[Token(Token = "0x4001129")]
		[FieldOffset(Offset = "0x10")]
		public List<GameObject> _frameJobs;
	}
}
