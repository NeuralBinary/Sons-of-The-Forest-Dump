using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000294 RID: 660
[Token(Token = "0x2000294")]
[Obsolete]
public class LoadSave : MonoBehaviour
{
	// Token: 0x14000010 RID: 16
	// (add) Token: 0x0600118F RID: 4495 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x06001190 RID: 4496 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x14000010")]
	public static event Action OnGameStart
	{
		[Token(Token = "0x600118F")]
		[Address(RVA = "0x37541D0", Offset = "0x37527D0", VA = "0x1837541D0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6001190")]
		[Address(RVA = "0x37542E0", Offset = "0x37528E0", VA = "0x1837542E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x06001191 RID: 4497 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001191")]
	[Address(RVA = "0x37543F0", Offset = "0x37529F0", VA = "0x1837543F0")]
	private void Awake()
	{
	}

	// Token: 0x06001192 RID: 4498 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001192")]
	[Address(RVA = "0x3754600", Offset = "0x3752C00", VA = "0x183754600")]
	private void Start()
	{
	}

	// Token: 0x06001193 RID: 4499 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001193")]
	[Address(RVA = "0x3754640", Offset = "0x3752C40", VA = "0x183754640")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001194 RID: 4500 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001194")]
	[Address(RVA = "0x37546D0", Offset = "0x3752CD0", VA = "0x1837546D0")]
	private void OnDisable()
	{
	}

	// Token: 0x06001195 RID: 4501 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001195")]
	[Address(RVA = "0x3754760", Offset = "0x3752D60", VA = "0x183754760")]
	public IEnumerator Activation(bool activate)
	{
		return null;
	}

	// Token: 0x06001196 RID: 4502 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001196")]
	[Address(RVA = "0x3754820", Offset = "0x3752E20", VA = "0x183754820")]
	private void SetStartSequenceStep(int step, float stepAlpha = 1f)
	{
	}

	// Token: 0x06001197 RID: 4503 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001197")]
	[Address(RVA = "0x37548E0", Offset = "0x3752EE0", VA = "0x1837548E0")]
	public void OnSaveSlotSelected()
	{
	}

	// Token: 0x06001198 RID: 4504 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001198")]
	[Address(RVA = "0x3754980", Offset = "0x3752F80", VA = "0x183754980")]
	private IEnumerator OnSaveSlotSelectedRoutine()
	{
		return null;
	}

	// Token: 0x06001199 RID: 4505 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001199")]
	[Address(RVA = "0x37549C0", Offset = "0x3752FC0", VA = "0x1837549C0")]
	public void OnSaveSlotSelectionCanceled()
	{
	}

	// Token: 0x0600119A RID: 4506 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600119A")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public LoadSave()
	{
	}

	// Token: 0x0400114E RID: 4430
	[Token(Token = "0x400114E")]
	[FieldOffset(Offset = "0x20")]
	public List<LoadSave.GameObjectList> _activateAfterLoading;

	// Token: 0x0400114F RID: 4431
	[Token(Token = "0x400114F")]
	[FieldOffset(Offset = "0x28")]
	private bool startedSequence;

	// Token: 0x02000295 RID: 661
	[Token(Token = "0x2000295")]
	[Serializable]
	public class GameObjectList
	{
		// Token: 0x0600119B RID: 4507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600119B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public GameObjectList()
		{
		}

		// Token: 0x04001150 RID: 4432
		[Token(Token = "0x4001150")]
		[FieldOffset(Offset = "0x10")]
		public List<GameObject> _frameJobs;
	}
}
