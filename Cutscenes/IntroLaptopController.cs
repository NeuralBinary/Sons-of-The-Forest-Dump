using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Cutscenes
{
	// Token: 0x02000775 RID: 1909
	[Token(Token = "0x2000775")]
	[AddComponentMenu("Sons/Cutscene/IntroLaptopController")]
	public class IntroLaptopController : MonoBehaviour
	{
		// Token: 0x06003222 RID: 12834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003222")]
		[Address(RVA = "0x2E46DA0", Offset = "0x2E45DA0", VA = "0x182E46DA0")]
		private void Start()
		{
		}

		// Token: 0x06003223 RID: 12835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003223")]
		[Address(RVA = "0x2E46F70", Offset = "0x2E45F70", VA = "0x182E46F70")]
		private void Update()
		{
		}

		// Token: 0x06003224 RID: 12836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003224")]
		[Address(RVA = "0x2E46B50", Offset = "0x2E45B50", VA = "0x182E46B50")]
		private void CheckInput()
		{
		}

		// Token: 0x06003225 RID: 12837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003225")]
		[Address(RVA = "0x2E46F80", Offset = "0x2E45F80", VA = "0x182E46F80")]
		public IntroLaptopController()
		{
		}

		// Token: 0x04002BB2 RID: 11186
		[Token(Token = "0x4002BB2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GameObject> _laptopScreens;

		// Token: 0x04002BB3 RID: 11187
		[Token(Token = "0x4002BB3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _closeLaptopTrigger;

		// Token: 0x04002BB4 RID: 11188
		[Token(Token = "0x4002BB4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _previousPageButton;

		// Token: 0x04002BB5 RID: 11189
		[Token(Token = "0x4002BB5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _nextPageButton;

		// Token: 0x04002BB6 RID: 11190
		[Token(Token = "0x4002BB6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _preventNextScreenSkipDelay;

		// Token: 0x04002BB7 RID: 11191
		[Token(Token = "0x4002BB7")]
		[FieldOffset(Offset = "0x44")]
		private int _currentScreen;

		// Token: 0x04002BB8 RID: 11192
		[Token(Token = "0x4002BB8")]
		[FieldOffset(Offset = "0x48")]
		private float _preventNextScreenSkip;
	}
}
