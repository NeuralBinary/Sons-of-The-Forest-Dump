using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gui
{
	// Token: 0x02000035 RID: 53
	[Token(Token = "0x2000035")]
	[AddComponentMenu("Sons/Gui/SaveGameIdSetter")]
	public class SaveGameIdSetter : MonoBehaviour
	{
		// Token: 0x0600014A RID: 330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x3011F00", Offset = "0x3010500", VA = "0x183011F00")]
		private void OnEnable()
		{
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x5FD590", Offset = "0x5FBB90", VA = "0x1805FD590")]
		public void SetSaveId(int saveId)
		{
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x3011F60", Offset = "0x3010560", VA = "0x183011F60")]
		public void Apply()
		{
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x3011FB0", Offset = "0x30105B0", VA = "0x183011FB0")]
		public void SetAndApply(int saveId)
		{
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SaveGameIdSetter()
		{
		}

		// Token: 0x0400014C RID: 332
		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int _saveId;

		// Token: 0x0400014D RID: 333
		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool _applyOnEnable;
	}
}
