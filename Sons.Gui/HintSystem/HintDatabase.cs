using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gui.HintSystem
{
	// Token: 0x0200006C RID: 108
	[Token(Token = "0x200006C")]
	[CreateAssetMenu(fileName = "HintDatabase", menuName = "Sons/Gui/Hints/HintDatabase", order = 0)]
	public class HintDatabase : ScriptableObject
	{
		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x000027C0 File Offset: 0x000009C0
		[Token(Token = "0x17000029")]
		public int Count
		{
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x305EE40", Offset = "0x305D440", VA = "0x18305EE40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x305EE80", Offset = "0x305D480", VA = "0x18305EE80")]
		public string GetHint(int index)
		{
			return null;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x305EF50", Offset = "0x305D550", VA = "0x18305EF50")]
		public string GetRandomHint()
		{
			return null;
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x305F000", Offset = "0x305D600", VA = "0x18305F000")]
		private void CheckRandomize()
		{
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x305F1D0", Offset = "0x305D7D0", VA = "0x18305F1D0")]
		public HintDatabase()
		{
		}

		// Token: 0x0400025B RID: 603
		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<HintDefinition> _definitions;

		// Token: 0x0400025C RID: 604
		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0x20")]
		private List<int> _randomizedIndices;

		// Token: 0x0400025D RID: 605
		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0x28")]
		private int _currentIndex;
	}
}
