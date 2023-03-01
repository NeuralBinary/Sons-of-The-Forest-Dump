using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Utils
{
	// Token: 0x020004F2 RID: 1266
	[Token(Token = "0x20004F2")]
	public class ToggleObjectsTimer : MonoBehaviour
	{
		// Token: 0x0600206D RID: 8301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600206D")]
		[Address(RVA = "0x2D33F50", Offset = "0x2D32F50", VA = "0x182D33F50")]
		private void Start()
		{
		}

		// Token: 0x0600206E RID: 8302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600206E")]
		[Address(RVA = "0x2D33C60", Offset = "0x2D32C60", VA = "0x182D33C60")]
		private void OnValidate()
		{
		}

		// Token: 0x0600206F RID: 8303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600206F")]
		[Address(RVA = "0x2D33C60", Offset = "0x2D32C60", VA = "0x182D33C60")]
		private void Convert()
		{
		}

		// Token: 0x06002070 RID: 8304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002070")]
		[Address(RVA = "0x2D33F80", Offset = "0x2D32F80", VA = "0x182D33F80")]
		private void Update()
		{
		}

		// Token: 0x06002071 RID: 8305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002071")]
		[Address(RVA = "0x2D33DB0", Offset = "0x2D32DB0", VA = "0x182D33DB0")]
		private void DoToggle()
		{
		}

		// Token: 0x06002072 RID: 8306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002072")]
		[Address(RVA = "0x2D33DF0", Offset = "0x2D32DF0", VA = "0x182D33DF0")]
		private void SetActive(List<GameObject> targetList, bool value)
		{
		}

		// Token: 0x06002073 RID: 8307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002073")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public ToggleObjectsTimer()
		{
		}

		// Token: 0x04001E2E RID: 7726
		[Token(Token = "0x4001E2E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		[FormerlySerializedAs("CurrentLight")]
		private GameObject _currentLight;

		// Token: 0x04001E2F RID: 7727
		[Token(Token = "0x4001E2F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[HideInInspector]
		[FormerlySerializedAs("TargetLight")]
		private GameObject _targetLight;

		// Token: 0x04001E30 RID: 7728
		[Token(Token = "0x4001E30")]
		[FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("_switchTime")]
		[FormerlySerializedAs("SwitchTime")]
		[SerializeField]
		private float _toggleTime;

		// Token: 0x04001E31 RID: 7729
		[Token(Token = "0x4001E31")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<GameObject> _disableObjects;

		// Token: 0x04001E32 RID: 7730
		[Token(Token = "0x4001E32")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<GameObject> _enableObjects;

		// Token: 0x04001E33 RID: 7731
		[Token(Token = "0x4001E33")]
		[FieldOffset(Offset = "0x48")]
		private bool _toggled;
	}
}
