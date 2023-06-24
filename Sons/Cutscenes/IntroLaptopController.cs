using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Cutscenes
{
	// Token: 0x02000680 RID: 1664
	[Token(Token = "0x2000680")]
	[AddComponentMenu("Sons/Cutscene/IntroLaptopController")]
	public class IntroLaptopController : MonoBehaviour
	{
		// Token: 0x06002B99 RID: 11161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B99")]
		[Address(RVA = "0x3410FF0", Offset = "0x340F5F0", VA = "0x183410FF0")]
		private void Start()
		{
		}

		// Token: 0x06002B9A RID: 11162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B9A")]
		[Address(RVA = "0x3411340", Offset = "0x340F940", VA = "0x183411340")]
		private void Update()
		{
		}

		// Token: 0x06002B9B RID: 11163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B9B")]
		[Address(RVA = "0x3411350", Offset = "0x340F950", VA = "0x183411350")]
		private void CheckInput()
		{
		}

		// Token: 0x06002B9C RID: 11164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B9C")]
		[Address(RVA = "0x3411600", Offset = "0x340FC00", VA = "0x183411600")]
		public IntroLaptopController()
		{
		}

		// Token: 0x04002685 RID: 9861
		[Token(Token = "0x4002685")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GameObject> _laptopScreens;

		// Token: 0x04002686 RID: 9862
		[Token(Token = "0x4002686")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _closeLaptopTrigger;

		// Token: 0x04002687 RID: 9863
		[Token(Token = "0x4002687")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _previousPageButton;

		// Token: 0x04002688 RID: 9864
		[Token(Token = "0x4002688")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _nextPageButton;

		// Token: 0x04002689 RID: 9865
		[Token(Token = "0x4002689")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _preventNextScreenSkipDelay;

		// Token: 0x0400268A RID: 9866
		[Token(Token = "0x400268A")]
		[FieldOffset(Offset = "0x44")]
		private int _currentScreen;

		// Token: 0x0400268B RID: 9867
		[Token(Token = "0x400268B")]
		[FieldOffset(Offset = "0x48")]
		private float _preventNextScreenSkip;
	}
}
