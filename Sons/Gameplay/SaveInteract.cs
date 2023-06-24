using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020007E6 RID: 2022
	[Token(Token = "0x20007E6")]
	[AddComponentMenu("Sons/Gameplay/SaveInteract")]
	public class SaveInteract : MonoBehaviour
	{
		// Token: 0x06003693 RID: 13971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003693")]
		[Address(RVA = "0x352EAE0", Offset = "0x352D0E0", VA = "0x18352EAE0")]
		private void Awake()
		{
		}

		// Token: 0x06003694 RID: 13972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003694")]
		[Address(RVA = "0x352EB40", Offset = "0x352D140", VA = "0x18352EB40")]
		private void Update()
		{
		}

		// Token: 0x06003695 RID: 13973 RVA: 0x00010548 File Offset: 0x0000E748
		[Token(Token = "0x6003695")]
		[Address(RVA = "0x352ECF0", Offset = "0x352D2F0", VA = "0x18352ECF0")]
		private bool CanInteract()
		{
			return default(bool);
		}

		// Token: 0x06003696 RID: 13974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003696")]
		[Address(RVA = "0x352ED70", Offset = "0x352D370", VA = "0x18352ED70")]
		private void OnDisable()
		{
		}

		// Token: 0x06003697 RID: 13975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003697")]
		[Address(RVA = "0x352ED70", Offset = "0x352D370", VA = "0x18352ED70")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003698 RID: 13976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003698")]
		[Address(RVA = "0x352ED80", Offset = "0x352D380", VA = "0x18352ED80")]
		private void GrabEnter()
		{
		}

		// Token: 0x06003699 RID: 13977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003699")]
		[Address(RVA = "0x352EAE0", Offset = "0x352D0E0", VA = "0x18352EAE0")]
		private void GrabExit()
		{
		}

		// Token: 0x0600369A RID: 13978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600369A")]
		[Address(RVA = "0x352EEA0", Offset = "0x352D4A0", VA = "0x18352EEA0")]
		private void SetShowIcon(bool value)
		{
		}

		// Token: 0x0600369B RID: 13979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600369B")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SaveInteract()
		{
		}

		// Token: 0x04002F2D RID: 12077
		[Token(Token = "0x4002F2D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _saveIcon;

		// Token: 0x04002F2E RID: 12078
		[Token(Token = "0x4002F2E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _minIconDistance;

		// Token: 0x04002F2F RID: 12079
		[Token(Token = "0x4002F2F")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _maxIconDistance;

		// Token: 0x04002F30 RID: 12080
		[Token(Token = "0x4002F30")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _iconDistanceToPlayer;
	}
}
