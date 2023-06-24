using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Prefabs
{
	// Token: 0x02000536 RID: 1334
	[Token(Token = "0x2000536")]
	public class PrefabManager : MonoBehaviour
	{
		// Token: 0x06002362 RID: 9058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002362")]
		[Address(RVA = "0x334CCA0", Offset = "0x334B2A0", VA = "0x18334CCA0")]
		private void CleanupInstance()
		{
		}

		// Token: 0x06002363 RID: 9059 RVA: 0x0000A6B0 File Offset: 0x000088B0
		[Token(Token = "0x6002363")]
		[Address(RVA = "0x334CE30", Offset = "0x334B430", VA = "0x18334CE30")]
		private bool SetupInstance()
		{
			return default(bool);
		}

		// Token: 0x06002364 RID: 9060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002364")]
		[Address(RVA = "0x334D0D0", Offset = "0x334B6D0", VA = "0x18334D0D0")]
		private void Awake()
		{
		}

		// Token: 0x06002365 RID: 9061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002365")]
		[Address(RVA = "0x334CCA0", Offset = "0x334B2A0", VA = "0x18334CCA0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002366 RID: 9062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002366")]
		[Address(RVA = "0x334D190", Offset = "0x334B790", VA = "0x18334D190")]
		private void SetupDebugCommands()
		{
		}

		// Token: 0x06002367 RID: 9063 RVA: 0x0000A6C8 File Offset: 0x000088C8
		[Token(Token = "0x6002367")]
		[Address(RVA = "0x334D240", Offset = "0x334B840", VA = "0x18334D240")]
		private bool DebugCommandAddPrefab(string arguments)
		{
			return default(bool);
		}

		// Token: 0x06002368 RID: 9064 RVA: 0x0000A6E0 File Offset: 0x000088E0
		[Token(Token = "0x6002368")]
		[Address(RVA = "0x334D800", Offset = "0x334BE00", VA = "0x18334D800")]
		public bool TryCreateInstance(string id, Vector3 location, out GameObject instance)
		{
			return default(bool);
		}

		// Token: 0x06002369 RID: 9065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002369")]
		[Address(RVA = "0x334D8B0", Offset = "0x334BEB0", VA = "0x18334D8B0")]
		private PrefabDefinition GetDefinition(string id)
		{
			return null;
		}

		// Token: 0x0600236A RID: 9066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600236A")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public PrefabManager()
		{
		}

		// Token: 0x04001FFF RID: 8191
		[Token(Token = "0x4001FFF")]
		[FieldOffset(Offset = "0x0")]
		private static PrefabManager _instance;

		// Token: 0x04002000 RID: 8192
		[Token(Token = "0x4002000")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<PrefabDefinition> _definitions;
	}
}
