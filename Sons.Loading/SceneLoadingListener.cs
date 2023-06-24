using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Loading
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	public abstract class SceneLoadingListener : MonoBehaviour, ISceneLoadingListener
	{
		// Token: 0x0600003D RID: 61 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x30B7CB0", Offset = "0x30B62B0", VA = "0x1830B7CB0", Slot = "7")]
		public virtual void OnEnable()
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x30B8120", Offset = "0x30B6720", VA = "0x1830B8120", Slot = "8")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x30B82F0", Offset = "0x30B68F0", VA = "0x1830B82F0")]
		protected void OnValidate()
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "9")]
		public virtual void ErrorFallback()
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "10")]
		public virtual void Completed()
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "11")]
		public virtual void UpdateProgress(float progressPercent)
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "12")]
		public virtual void UpdateInfo(string message)
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		protected SceneLoadingListener()
		{
		}

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GuidReference _loadSceneReference;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _findLoadScene;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LoadScene _loadScene;
	}
}
