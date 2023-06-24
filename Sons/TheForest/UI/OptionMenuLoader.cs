using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x020003F4 RID: 1012
	[Token(Token = "0x20003F4")]
	public class OptionMenuLoader : MonoBehaviour
	{
		// Token: 0x06001B37 RID: 6967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B37")]
		[Address(RVA = "0x32B3D70", Offset = "0x32B2370", VA = "0x1832B3D70")]
		private void Awake()
		{
		}

		// Token: 0x06001B38 RID: 6968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B38")]
		[Address(RVA = "0x32B45A0", Offset = "0x32B2BA0", VA = "0x1832B45A0")]
		private void OnEnable()
		{
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B39")]
		[Address(RVA = "0x32B45C0", Offset = "0x32B2BC0", VA = "0x1832B45C0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06001B3A RID: 6970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B3A")]
		[Address(RVA = "0x32B4680", Offset = "0x32B2C80", VA = "0x1832B4680")]
		private IEnumerator StartTweenAnimationWorker()
		{
			return null;
		}

		// Token: 0x06001B3B RID: 6971 RVA: 0x00008268 File Offset: 0x00006468
		[Token(Token = "0x6001B3B")]
		[Address(RVA = "0x32B4710", Offset = "0x32B2D10", VA = "0x1832B4710")]
		private int GetScreenResolutionHash()
		{
			return 0;
		}

		// Token: 0x06001B3C RID: 6972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B3C")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public OptionMenuLoader()
		{
		}

		// Token: 0x04001A6D RID: 6765
		[Token(Token = "0x4001A6D")]
		[FieldOffset(Offset = "0x20")]
		public Transform _optionMenuPrefab;

		// Token: 0x04001A6E RID: 6766
		[Token(Token = "0x4001A6E")]
		[FieldOffset(Offset = "0x28")]
		public Transform _optionMenuPrefabPS4;

		// Token: 0x04001A6F RID: 6767
		[Token(Token = "0x4001A6F")]
		[FieldOffset(Offset = "0x30")]
		public GameObject _mainMenuGO;

		// Token: 0x04001A70 RID: 6768
		[Token(Token = "0x4001A70")]
		[FieldOffset(Offset = "0x38")]
		public GameObject _controlSettingsGO;

		// Token: 0x04001A71 RID: 6769
		[Token(Token = "0x4001A71")]
		[FieldOffset(Offset = "0x40")]
		public GameObject _normalCursor;

		// Token: 0x04001A72 RID: 6770
		[Token(Token = "0x4001A72")]
		[FieldOffset(Offset = "0x48")]
		private int _screenResolutionHash;

		// Token: 0x04001A73 RID: 6771
		[Token(Token = "0x4001A73")]
		[FieldOffset(Offset = "0x4C")]
		private bool _tweenAnimationWorkerActive;
	}
}
