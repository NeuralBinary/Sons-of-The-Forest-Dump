using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x02000402 RID: 1026
	[Token(Token = "0x2000402")]
	public class OptionMenuLoader : MonoBehaviour
	{
		// Token: 0x06001AF9 RID: 6905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AF9")]
		[Address(RVA = "0x2CE76A0", Offset = "0x2CE66A0", VA = "0x182CE76A0")]
		private void Awake()
		{
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AFA")]
		[Address(RVA = "0x2CE7BD0", Offset = "0x2CE6BD0", VA = "0x182CE7BD0")]
		private void OnEnable()
		{
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AFB")]
		[Address(RVA = "0x2CE7B30", Offset = "0x2CE6B30", VA = "0x182CE7B30")]
		private void LateUpdate()
		{
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AFC")]
		[Address(RVA = "0x2CE7C10", Offset = "0x2CE6C10", VA = "0x182CE7C10")]
		private IEnumerator StartTweenAnimationWorker()
		{
			return null;
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x00007FE0 File Offset: 0x000061E0
		[Token(Token = "0x6001AFD")]
		[Address(RVA = "0x2CE7B00", Offset = "0x2CE6B00", VA = "0x182CE7B00")]
		private int GetScreenResolutionHash()
		{
			return default(int);
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AFE")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public OptionMenuLoader()
		{
		}

		// Token: 0x04001A49 RID: 6729
		[Token(Token = "0x4001A49")]
		[FieldOffset(Offset = "0x20")]
		public Transform _optionMenuPrefab;

		// Token: 0x04001A4A RID: 6730
		[Token(Token = "0x4001A4A")]
		[FieldOffset(Offset = "0x28")]
		public Transform _optionMenuPrefabPS4;

		// Token: 0x04001A4B RID: 6731
		[Token(Token = "0x4001A4B")]
		[FieldOffset(Offset = "0x30")]
		public GameObject _mainMenuGO;

		// Token: 0x04001A4C RID: 6732
		[Token(Token = "0x4001A4C")]
		[FieldOffset(Offset = "0x38")]
		public GameObject _controlSettingsGO;

		// Token: 0x04001A4D RID: 6733
		[Token(Token = "0x4001A4D")]
		[FieldOffset(Offset = "0x40")]
		public GameObject _normalCursor;

		// Token: 0x04001A4E RID: 6734
		[Token(Token = "0x4001A4E")]
		[FieldOffset(Offset = "0x48")]
		private int _screenResolutionHash;

		// Token: 0x04001A4F RID: 6735
		[Token(Token = "0x4001A4F")]
		[FieldOffset(Offset = "0x4C")]
		private bool _tweenAnimationWorkerActive;
	}
}
