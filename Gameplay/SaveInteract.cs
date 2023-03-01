using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020006B0 RID: 1712
	[Token(Token = "0x20006B0")]
	[AddComponentMenu("Sons/Gameplay/SaveInteract")]
	public class SaveInteract : MonoBehaviour
	{
		// Token: 0x06002BD9 RID: 11225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BD9")]
		[Address(RVA = "0x2DF20F0", Offset = "0x2DF10F0", VA = "0x182DF20F0")]
		private void Awake()
		{
		}

		// Token: 0x06002BDA RID: 11226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BDA")]
		[Address(RVA = "0x2DF2240", Offset = "0x2DF1240", VA = "0x182DF2240")]
		private void Update()
		{
		}

		// Token: 0x06002BDB RID: 11227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BDB")]
		[Address(RVA = "0x2DF21A0", Offset = "0x2DF11A0", VA = "0x182DF21A0")]
		private void OnDisable()
		{
		}

		// Token: 0x06002BDC RID: 11228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BDC")]
		[Address(RVA = "0x2DF21A0", Offset = "0x2DF11A0", VA = "0x182DF21A0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002BDD RID: 11229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BDD")]
		[Address(RVA = "0x2DF2120", Offset = "0x2DF1120", VA = "0x182DF2120")]
		private void GrabEnter()
		{
		}

		// Token: 0x06002BDE RID: 11230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BDE")]
		[Address(RVA = "0x2DF20F0", Offset = "0x2DF10F0", VA = "0x182DF20F0")]
		private void GrabExit()
		{
		}

		// Token: 0x06002BDF RID: 11231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BDF")]
		[Address(RVA = "0x2DF21B0", Offset = "0x2DF11B0", VA = "0x182DF21B0")]
		private void SetShowIcon(bool value)
		{
		}

		// Token: 0x06002BE0 RID: 11232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BE0")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public SaveInteract()
		{
		}

		// Token: 0x04002757 RID: 10071
		[Token(Token = "0x4002757")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _saveIcon;

		// Token: 0x04002758 RID: 10072
		[Token(Token = "0x4002758")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _minIconDistance;

		// Token: 0x04002759 RID: 10073
		[Token(Token = "0x4002759")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _maxIconDistance;

		// Token: 0x0400275A RID: 10074
		[Token(Token = "0x400275A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _iconDistanceToPlayer;
	}
}
