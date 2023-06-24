using System;
using Il2CppDummyDll;
using Sons.Save;
using UnityEngine;

namespace Sons.Gui
{
	// Token: 0x02000036 RID: 54
	[Token(Token = "0x2000036")]
	[AddComponentMenu("Sons/Gui/SaveGameTypeSetter")]
	[DefaultExecutionOrder(1000)]
	public class SaveGameTypeSetter : MonoBehaviour
	{
		// Token: 0x0600014F RID: 335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x3012000", Offset = "0x3010600", VA = "0x183012000")]
		private void OnEnable()
		{
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void DelayApply()
		{
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x30121D0", Offset = "0x30107D0", VA = "0x1830121D0")]
		private void Update()
		{
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x30121F0", Offset = "0x30107F0", VA = "0x1830121F0")]
		public void Apply()
		{
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x30122C0", Offset = "0x30108C0", VA = "0x1830122C0")]
		public SaveGameTypeSetter()
		{
		}

		// Token: 0x0400014E RID: 334
		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SaveGameType _saveGameType;

		// Token: 0x0400014F RID: 335
		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool _applyOnEnable;

		// Token: 0x04000150 RID: 336
		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x25")]
		[SerializeField]
		private bool _waitForSceneLoaded;

		// Token: 0x04000151 RID: 337
		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x26")]
		private bool _hasApplied;
	}
}
