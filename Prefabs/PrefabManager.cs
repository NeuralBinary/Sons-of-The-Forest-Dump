using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Prefabs
{
	// Token: 0x0200052E RID: 1326
	[Token(Token = "0x200052E")]
	public class PrefabManager : MonoBehaviour
	{
		// Token: 0x06002275 RID: 8821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002275")]
		[Address(RVA = "0x2D64F40", Offset = "0x2D63F40", VA = "0x182D64F40")]
		private void CleanupInstance()
		{
		}

		// Token: 0x06002276 RID: 8822 RVA: 0x0000A068 File Offset: 0x00008268
		[Token(Token = "0x6002276")]
		[Address(RVA = "0x2D656D0", Offset = "0x2D646D0", VA = "0x182D656D0")]
		private bool SetupInstance()
		{
			return default(bool);
		}

		// Token: 0x06002277 RID: 8823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002277")]
		[Address(RVA = "0x2D64DA0", Offset = "0x2D63DA0", VA = "0x182D64DA0")]
		private void Awake()
		{
		}

		// Token: 0x06002278 RID: 8824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002278")]
		[Address(RVA = "0x2D64F40", Offset = "0x2D63F40", VA = "0x182D64F40")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002279 RID: 8825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002279")]
		[Address(RVA = "0x2D65620", Offset = "0x2D64620", VA = "0x182D65620")]
		private void SetupDebugCommands()
		{
		}

		// Token: 0x0600227A RID: 8826 RVA: 0x0000A080 File Offset: 0x00008280
		[Token(Token = "0x600227A")]
		[Address(RVA = "0x2D64FF0", Offset = "0x2D63FF0", VA = "0x182D64FF0")]
		private bool DebugCommandAddPrefab(string arguments)
		{
			return default(bool);
		}

		// Token: 0x0600227B RID: 8827 RVA: 0x0000A098 File Offset: 0x00008298
		[Token(Token = "0x600227B")]
		[Address(RVA = "0x2D657F0", Offset = "0x2D647F0", VA = "0x182D657F0")]
		public bool TryCreateInstance(string id, Vector3 location, out GameObject instance)
		{
			return default(bool);
		}

		// Token: 0x0600227C RID: 8828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600227C")]
		[Address(RVA = "0x2D654D0", Offset = "0x2D644D0", VA = "0x182D654D0")]
		private PrefabDefinition GetDefinition(string id)
		{
			return null;
		}

		// Token: 0x0600227D RID: 8829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600227D")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public PrefabManager()
		{
		}

		// Token: 0x04001F4B RID: 8011
		[Token(Token = "0x4001F4B")]
		[FieldOffset(Offset = "0x0")]
		private static PrefabManager _instance;

		// Token: 0x04001F4C RID: 8012
		[Token(Token = "0x4001F4C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<PrefabDefinition> _definitions;
	}
}
