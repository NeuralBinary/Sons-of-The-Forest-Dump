using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Utils
{
	// Token: 0x020004EC RID: 1260
	[Token(Token = "0x20004EC")]
	public class ToggleObjectsTimer : MonoBehaviour
	{
		// Token: 0x06002109 RID: 8457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002109")]
		[Address(RVA = "0x33216E0", Offset = "0x331FCE0", VA = "0x1833216E0")]
		private void Start()
		{
		}

		// Token: 0x0600210A RID: 8458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600210A")]
		[Address(RVA = "0x3321750", Offset = "0x331FD50", VA = "0x183321750")]
		private void OnValidate()
		{
		}

		// Token: 0x0600210B RID: 8459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600210B")]
		[Address(RVA = "0x3321760", Offset = "0x331FD60", VA = "0x183321760")]
		private void Convert()
		{
		}

		// Token: 0x0600210C RID: 8460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600210C")]
		[Address(RVA = "0x33219E0", Offset = "0x331FFE0", VA = "0x1833219E0")]
		private void Update()
		{
		}

		// Token: 0x0600210D RID: 8461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600210D")]
		[Address(RVA = "0x3321A70", Offset = "0x3320070", VA = "0x183321A70")]
		private void DoToggle()
		{
		}

		// Token: 0x0600210E RID: 8462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600210E")]
		[Address(RVA = "0x3321AB0", Offset = "0x33200B0", VA = "0x183321AB0")]
		private void SetActive(List<GameObject> targetList, bool value)
		{
		}

		// Token: 0x0600210F RID: 8463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600210F")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ToggleObjectsTimer()
		{
		}

		// Token: 0x04001E9E RID: 7838
		[Token(Token = "0x4001E9E")]
		[FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("CurrentLight")]
		[SerializeField]
		[HideInInspector]
		private GameObject _currentLight;

		// Token: 0x04001E9F RID: 7839
		[Token(Token = "0x4001E9F")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		[SerializeField]
		[FormerlySerializedAs("TargetLight")]
		private GameObject _targetLight;

		// Token: 0x04001EA0 RID: 7840
		[Token(Token = "0x4001EA0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[FormerlySerializedAs("SwitchTime")]
		[FormerlySerializedAs("_switchTime")]
		private float _toggleTime;

		// Token: 0x04001EA1 RID: 7841
		[Token(Token = "0x4001EA1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<GameObject> _disableObjects;

		// Token: 0x04001EA2 RID: 7842
		[Token(Token = "0x4001EA2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<GameObject> _enableObjects;

		// Token: 0x04001EA3 RID: 7843
		[Token(Token = "0x4001EA3")]
		[FieldOffset(Offset = "0x48")]
		private bool _toggled;
	}
}
