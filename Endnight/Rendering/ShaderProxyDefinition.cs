using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Rendering
{
	// Token: 0x02000087 RID: 135
	[Token(Token = "0x2000087")]
	[Serializable]
	public class ShaderProxyDefinition
	{
		// Token: 0x060002F2 RID: 754 RVA: 0x000036C0 File Offset: 0x000018C0
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xA96F90", Offset = "0xA95590", VA = "0x180A96F90")]
		public bool MatchesProxy(string shaderName)
		{
			return default(bool);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xA97040", Offset = "0xA95640", VA = "0x180A97040")]
		public static void ProcessShaderProxies(GameObject sourceGameObject, ShaderProxyDefinition[] shaderProxyDefinitions, Dictionary<Material, Material> swappedMaterialsCache)
		{
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xA97220", Offset = "0xA95820", VA = "0x180A97220")]
		public static void ProcessShaderProxies(Renderer targetRenderer, ShaderProxyDefinition[] shaderProxyDefinitions, Dictionary<Material, Material> swappedMaterialsCache)
		{
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x000036D8 File Offset: 0x000018D8
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0xA97340", Offset = "0xA95940", VA = "0x180A97340")]
		private static bool ProcessShaderProxies(ShaderProxyDefinition[] shaderProxyDefinitions, ref Material eachMaterial, Dictionary<Material, Material> swappedMaterialsCache)
		{
			return default(bool);
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ShaderProxyDefinition()
		{
		}

		// Token: 0x040001CA RID: 458
		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Shader _proxyShader;

		// Token: 0x040001CB RID: 459
		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Shader _realShader;
	}
}
