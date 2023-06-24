using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Input
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	public class InputTypeToggleGameObject : MonoBehaviour
	{
		// Token: 0x0600013C RID: 316 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x307CFE0", Offset = "0x307B5E0", VA = "0x18307CFE0")]
		private void Start()
		{
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x307CFF0", Offset = "0x307B5F0", VA = "0x18307CFF0")]
		private void Update()
		{
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x307D0C0", Offset = "0x307B6C0", VA = "0x18307D0C0")]
		private void Apply()
		{
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public InputTypeToggleGameObject()
		{
		}

		// Token: 0x0400017A RID: 378
		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("_gamepadGo")]
		public GameObject _gamepadGameObject;

		// Token: 0x0400017B RID: 379
		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("_otherGo")]
		public GameObject _keyboardGameObject;

		// Token: 0x0400017C RID: 380
		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x30")]
		private bool _previouslyAppliedGamepad;

		// Token: 0x0400017D RID: 381
		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x31")]
		private bool _previouslyAppliedKeyboard;
	}
}
