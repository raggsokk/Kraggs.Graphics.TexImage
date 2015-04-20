///////////////////////////////////////////////////////////////////////////////////
/// OpenGL Image (gli.g-truc.net)
///
/// Copyright (c) 2008 - 2012 G-Truc Creation (www.g-truc.net)
/// Permission is hereby granted, free of charge, to any person obtaining a copy
/// of this software and associated documentation files (the "Software"), to deal
/// in the Software without restriction, including without limitation the rights
/// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
/// copies of the Software, and to permit persons to whom the Software is
/// furnished to do so, subject to the following conditions:
/// 
/// The above copyright notice and this permission notice shall be included in
/// all copies or substantial portions of the Software.
/// 
/// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
/// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
/// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
/// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
/// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
/// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
/// THE SOFTWARE.
///
/// @ref core
/// @file gli/core/format.hpp
/// @date 2012-10-16 / 2012-10-16
/// @author Christophe Riccio
///////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;

using System.Diagnostics;

namespace Kraggs.Graphics.TexImage.GLIDesc
{
    /// <summary>
    /// The description structure for a gliformat.
    /// TODO: Should this structure be public?
    /// </summary>
    internal class GLIFormatDesc
    {
        /// <summary>
        /// The number of bytes in the minimum editable block.
        /// </summary>
        public int BlockSize;
        /// <summary>
        /// Width of the minimum editable block.
        /// 1 texel for uncompressed formats, for DXT1 its 4.
        /// </summary>
        public int BlockWidth;
        /// <summary>
        /// Height of the minimum editable block.
        /// 1 texel for uncompressed formats, for DXT1 its 4.
        /// </summary>
        public int BlockHeight;
        /// <summary>
        /// Depth of the mimimum editable block.
        /// 1 texel for uncompressed formats, for DXT1 its 1.
        /// </summary>
        public int BlockDepth;
        /// <summary>
        /// Bits Per Pixel. Usually BlockSize * 8 / (BlockW * BlockH * BlockD)
        /// aka RGBA8 = 4 * 8 = 32 / (1*1*1) = 32;
        /// aka DXT5 = 16 * 8 = 128 / (4*4*1) = 8;
        /// </summary>
        public int BitsPerPixel;

        /// <summary>
        /// The number of components/channels in this format. RGB=3, RGBA=4.
        /// </summary>
        public int Components;

        /// <summary>
        /// Is this a compressed format.
        /// </summary>
        public bool IsCompressed;

        public GLIInternalFormat InternalFormat { get; set; }
        public GLIExternalFormat ExternalFormat { get; set; }
        public GLITypeFormat TypeFormat { get; set; }

        internal static readonly GLIFormatDesc None = new GLIFormatDesc() 
        {
            BlockSize = 0, BlockWidth = 0, BlockHeight = 0, BlockDepth = 0, BitsPerPixel = 0, Components = 0, IsCompressed = false,
            InternalFormat = GLIInternalFormat.INTERNAL_NONE, ExternalFormat = GLIExternalFormat.EXTERNAL_NONE, TypeFormat = GLITypeFormat.TYPE_NONE
        };

        internal GLIFormatDesc()
        {}

        internal GLIFormatDesc(int BitsPerPixel, int Components, GLIInternalFormat internalFormat, GLIExternalFormat externalFormat, GLITypeFormat typeFormat )
        {
            this.BitsPerPixel = BitsPerPixel;
            this.Components = Components;

            this.BlockSize = BitsPerPixel / 8;
            this.BlockWidth = this.BlockHeight = this.BlockDepth = 1;
            this.IsCompressed = false;

            this.InternalFormat = internalFormat;
            this.ExternalFormat = externalFormat;
            this.TypeFormat = typeFormat;
        }

        internal GLIFormatDesc(int BlockSize, int BlockWidth, int BlockHeight, int BlockDepth, int BitsPerPixel, int Components, bool isCompressed, GLIInternalFormat internalFormat, GLIExternalFormat externalFormat, GLITypeFormat typeFormat)
        {
            this.BlockSize = BlockSize;
            this.BlockWidth = BlockWidth;
            this.BlockHeight = BlockHeight;
            this.BlockDepth = BlockDepth;
            this.BitsPerPixel = BitsPerPixel;
            this.Components = Components;
            this.IsCompressed = isCompressed;
            this.InternalFormat = internalFormat;
            this.ExternalFormat = externalFormat;
            this.TypeFormat = typeFormat;
        }

        internal static readonly GLIFormatDesc[] Desc = new GLIFormatDesc[]
        {
            //DIFF: Different from upstream.
            None,

            // unorm formats
            new GLIFormatDesc(8, 1, GLIInternalFormat.INTERNAL_R8_UNORM, GLIExternalFormat.EXTERNAL_RED, GLITypeFormat.TYPE_U8),
            new GLIFormatDesc(16, 2, GLIInternalFormat.INTERNAL_RG8_UNORM, GLIExternalFormat.EXTERNAL_RG, GLITypeFormat.TYPE_U8),
            new GLIFormatDesc(24, 3, GLIInternalFormat.INTERNAL_RGB8_UNORM, GLIExternalFormat.EXTERNAL_RGB, GLITypeFormat.TYPE_U8),
            new GLIFormatDesc(32, 4, GLIInternalFormat.INTERNAL_RGBA8_UNORM, GLIExternalFormat.EXTERNAL_RGBA, GLITypeFormat.TYPE_U8),

            new GLIFormatDesc(16, 1, GLIInternalFormat.INTERNAL_R16_UNORM, GLIExternalFormat.EXTERNAL_RED, GLITypeFormat.TYPE_U16),
            new GLIFormatDesc(32, 2, GLIInternalFormat.INTERNAL_RG16_UNORM, GLIExternalFormat.EXTERNAL_RG, GLITypeFormat.TYPE_U16),
            new GLIFormatDesc(48, 3, GLIInternalFormat.INTERNAL_RGB16_UNORM, GLIExternalFormat.EXTERNAL_RGB, GLITypeFormat.TYPE_U16),
            new GLIFormatDesc(64, 4, GLIInternalFormat.INTERNAL_RGBA16_UNORM, GLIExternalFormat.EXTERNAL_RGBA, GLITypeFormat.TYPE_U16),

            new GLIFormatDesc() { BlockSize = 4, BlockWidth = 1, BlockHeight = 1, BlockDepth = 1, BitsPerPixel = 32, Components = 4, IsCompressed = false, InternalFormat = GLIInternalFormat.INTERNAL_RGB10A2, ExternalFormat = GLIExternalFormat.EXTERNAL_RGBA, TypeFormat = GLITypeFormat.TYPE_UINT32_RGB10A2 },

            // snorm formats
            new GLIFormatDesc(8, 1, GLIInternalFormat.INTERNAL_R8_SNORM, GLIExternalFormat.EXTERNAL_RED, GLITypeFormat.TYPE_I8),
            new GLIFormatDesc(16, 2, GLIInternalFormat.INTERNAL_RG8_SNORM, GLIExternalFormat.EXTERNAL_RG, GLITypeFormat.TYPE_I8),
            new GLIFormatDesc(24, 3, GLIInternalFormat.INTERNAL_RGB8_SNORM, GLIExternalFormat.EXTERNAL_RGB, GLITypeFormat.TYPE_I8),
            new GLIFormatDesc(32, 4, GLIInternalFormat.INTERNAL_RGBA8_SNORM, GLIExternalFormat.EXTERNAL_RGBA, GLITypeFormat.TYPE_I8),

            new GLIFormatDesc(16, 1, GLIInternalFormat.INTERNAL_R16_SNORM, GLIExternalFormat.EXTERNAL_RED, GLITypeFormat.TYPE_I16),
            new GLIFormatDesc(32, 2, GLIInternalFormat.INTERNAL_RG16_SNORM, GLIExternalFormat.EXTERNAL_RG, GLITypeFormat.TYPE_I16),
            new GLIFormatDesc(48, 3, GLIInternalFormat.INTERNAL_RGB16_SNORM, GLIExternalFormat.EXTERNAL_RGB, GLITypeFormat.TYPE_I16),
            new GLIFormatDesc(64, 4, GLIInternalFormat.INTERNAL_RGBA16_SNORM, GLIExternalFormat.EXTERNAL_RGBA, GLITypeFormat.TYPE_I16),

            // Unsigned integer formats
            new GLIFormatDesc(8, 1, GLIInternalFormat.INTERNAL_R8U, GLIExternalFormat.EXTERNAL_RED_INTEGER, GLITypeFormat.TYPE_U8),
            new GLIFormatDesc(16, 2, GLIInternalFormat.INTERNAL_RG8U, GLIExternalFormat.EXTERNAL_RG_INTEGER, GLITypeFormat.TYPE_U8),
            new GLIFormatDesc(24, 3, GLIInternalFormat.INTERNAL_RGB8U, GLIExternalFormat.EXTERNAL_RGB_INTEGER, GLITypeFormat.TYPE_U8),
            new GLIFormatDesc(32, 4, GLIInternalFormat.INTERNAL_RGBA8U, GLIExternalFormat.EXTERNAL_RGBA_INTEGER, GLITypeFormat.TYPE_U8),

            new GLIFormatDesc(16, 1, GLIInternalFormat.INTERNAL_R16U, GLIExternalFormat.EXTERNAL_RED_INTEGER, GLITypeFormat.TYPE_U16),
            new GLIFormatDesc(32, 2, GLIInternalFormat.INTERNAL_RG16U, GLIExternalFormat.EXTERNAL_RG_INTEGER, GLITypeFormat.TYPE_U16),
            new GLIFormatDesc(48, 3, GLIInternalFormat.INTERNAL_RGB16U, GLIExternalFormat.EXTERNAL_RGB_INTEGER, GLITypeFormat.TYPE_U16),
            new GLIFormatDesc(64, 4, GLIInternalFormat.INTERNAL_RGBA16U, GLIExternalFormat.EXTERNAL_RGBA_INTEGER, GLITypeFormat.TYPE_U16),

            new GLIFormatDesc(32, 1, GLIInternalFormat.INTERNAL_R32U, GLIExternalFormat.EXTERNAL_RED_INTEGER, GLITypeFormat.TYPE_U32),
            new GLIFormatDesc(64, 2, GLIInternalFormat.INTERNAL_RG32U, GLIExternalFormat.EXTERNAL_RG_INTEGER, GLITypeFormat.TYPE_U32),
            new GLIFormatDesc(96, 3, GLIInternalFormat.INTERNAL_RGB32U, GLIExternalFormat.EXTERNAL_RGB_INTEGER, GLITypeFormat.TYPE_U32),
            new GLIFormatDesc(128, 4, GLIInternalFormat.INTERNAL_RGBA32U, GLIExternalFormat.EXTERNAL_RGBA_INTEGER, GLITypeFormat.TYPE_U32),

            new GLIFormatDesc(32, 4, GLIInternalFormat.INTERNAL_RGB10A2U, GLIExternalFormat.EXTERNAL_RGBA, GLITypeFormat.TYPE_UINT32_RGB10A2),

            // Signed integer formats
            new GLIFormatDesc(8, 1, GLIInternalFormat.INTERNAL_R8I, GLIExternalFormat.EXTERNAL_RED_INTEGER, GLITypeFormat.TYPE_I8),
            new GLIFormatDesc(16, 2, GLIInternalFormat.INTERNAL_RG8I, GLIExternalFormat.EXTERNAL_RG_INTEGER, GLITypeFormat.TYPE_I8),
            new GLIFormatDesc(24, 3, GLIInternalFormat.INTERNAL_RGB8I, GLIExternalFormat.EXTERNAL_RGB_INTEGER, GLITypeFormat.TYPE_I8),
            new GLIFormatDesc(32, 4, GLIInternalFormat.INTERNAL_RGBA8I, GLIExternalFormat.EXTERNAL_RGBA_INTEGER, GLITypeFormat.TYPE_I8),

            new GLIFormatDesc(16, 1, GLIInternalFormat.INTERNAL_R16I, GLIExternalFormat.EXTERNAL_RED_INTEGER, GLITypeFormat.TYPE_I16),
            new GLIFormatDesc(32, 2, GLIInternalFormat.INTERNAL_RG16I, GLIExternalFormat.EXTERNAL_RG_INTEGER, GLITypeFormat.TYPE_I16),
            new GLIFormatDesc(48, 3, GLIInternalFormat.INTERNAL_RGB16I, GLIExternalFormat.EXTERNAL_RGB_INTEGER, GLITypeFormat.TYPE_I16),
            new GLIFormatDesc(64, 4, GLIInternalFormat.INTERNAL_RGBA16I, GLIExternalFormat.EXTERNAL_RGBA_INTEGER, GLITypeFormat.TYPE_I16),

            new GLIFormatDesc(32, 1, GLIInternalFormat.INTERNAL_R32I, GLIExternalFormat.EXTERNAL_RED_INTEGER, GLITypeFormat.TYPE_I32),
            new GLIFormatDesc(64, 2, GLIInternalFormat.INTERNAL_RG32I, GLIExternalFormat.EXTERNAL_RG_INTEGER, GLITypeFormat.TYPE_I32),
            new GLIFormatDesc(96, 3, GLIInternalFormat.INTERNAL_RGB32I, GLIExternalFormat.EXTERNAL_RGB_INTEGER, GLITypeFormat.TYPE_I32),
            new GLIFormatDesc(128, 4, GLIInternalFormat.INTERNAL_RGBA32I, GLIExternalFormat.EXTERNAL_RGBA_INTEGER, GLITypeFormat.TYPE_I32),

            // Floating formats
            new GLIFormatDesc(16, 1, GLIInternalFormat.INTERNAL_R16F, GLIExternalFormat.EXTERNAL_RED, GLITypeFormat.TYPE_F16),
            new GLIFormatDesc(32, 2, GLIInternalFormat.INTERNAL_RG16F, GLIExternalFormat.EXTERNAL_RG, GLITypeFormat.TYPE_F16),
            new GLIFormatDesc(48, 3, GLIInternalFormat.INTERNAL_RGB16F, GLIExternalFormat.EXTERNAL_RGB, GLITypeFormat.TYPE_F16),
            new GLIFormatDesc(64, 4, GLIInternalFormat.INTERNAL_RGBA16F, GLIExternalFormat.EXTERNAL_RGBA, GLITypeFormat.TYPE_F16),

            new GLIFormatDesc(32, 1, GLIInternalFormat.INTERNAL_R32F, GLIExternalFormat.EXTERNAL_RED, GLITypeFormat.TYPE_F32),
            new GLIFormatDesc(64, 2, GLIInternalFormat.INTERNAL_RG32F, GLIExternalFormat.EXTERNAL_RG, GLITypeFormat.TYPE_F32),
            new GLIFormatDesc(96, 3, GLIInternalFormat.INTERNAL_RGB32F, GLIExternalFormat.EXTERNAL_RGB, GLITypeFormat.TYPE_F32),
            new GLIFormatDesc(128, 4, GLIInternalFormat.INTERNAL_RGBA32F, GLIExternalFormat.EXTERNAL_RGBA, GLITypeFormat.TYPE_F32),

            // Packed formats
            new GLIFormatDesc(4, 1,1,1, 32, 3, false, GLIInternalFormat.INTERNAL_RGB9E5, GLIExternalFormat.EXTERNAL_RGBA, GLITypeFormat.TYPE_UINT32_RGB9_E5),
            new GLIFormatDesc(4, 1,1,1, 32, 3, false, GLIInternalFormat.INTERNAL_RG11B10F, GLIExternalFormat.EXTERNAL_RGBA, GLITypeFormat.TYPE_UINT32_RG11B10F),
            new GLIFormatDesc(1, 1,1,1, 8, 3, false, GLIInternalFormat.INTERNAL_RG3B2, GLIExternalFormat.EXTERNAL_RGB, GLITypeFormat.TYPE_UINT8_RG3B2),
            new GLIFormatDesc(2, 1,1,1, 16, 3, false, GLIInternalFormat.INTERNAL_R5G6B5, GLIExternalFormat.EXTERNAL_RGB, GLITypeFormat.TYPE_UINT16_R5G6B5),
            new GLIFormatDesc(2, 1,1,1, 16, 4, false, GLIInternalFormat.INTERNAL_RGB5A1, GLIExternalFormat.EXTERNAL_RGBA, GLITypeFormat.TYPE_UINT16_RGB5A1),
            new GLIFormatDesc(2, 1,1,1, 16, 4, false, GLIInternalFormat.INTERNAL_RGBA4, GLIExternalFormat.EXTERNAL_RGBA, GLITypeFormat.TYPE_UINT16_RGBA4),

            // Depth formats
            new GLIFormatDesc(2, 1,1,1, 16, 1, false, GLIInternalFormat.INTERNAL_D16, GLIExternalFormat.EXTERNAL_DEPTH, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(4, 1,1,1, 32, 1, false, GLIInternalFormat.INTERNAL_D24, GLIExternalFormat.EXTERNAL_DEPTH, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(4, 1,1,1, 32, 2, false, GLIInternalFormat.INTERNAL_D24S8, GLIExternalFormat.EXTERNAL_DEPTH_STENCIL, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(4, 1,1,1, 32, 1, false, GLIInternalFormat.INTERNAL_D32F, GLIExternalFormat.EXTERNAL_DEPTH, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(8, 1,1,1, 64, 2, false, GLIInternalFormat.INTERNAL_D32FS8X24, GLIExternalFormat.EXTERNAL_DEPTH_STENCIL, GLITypeFormat.TYPE_NONE),

            // Compressed formats
            new GLIFormatDesc(8, 4,4,1, 4, 3, true, GLIInternalFormat.INTERNAL_RGB_DXT1, GLIExternalFormat.EXTERNAL_RGB_DXT1, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(8, 4,4,1, 4, 4, true, GLIInternalFormat.INTERNAL_RGBA_DXT1, GLIExternalFormat.EXTERNAL_RGBA_DXT1, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(16, 4,4,1,8,4, true, GLIInternalFormat.INTERNAL_RGBA_DXT3, GLIExternalFormat.EXTERNAL_RGBA_DXT3, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(16, 4,4,1,8,4, true, GLIInternalFormat.INTERNAL_RGBA_DXT5, GLIExternalFormat.EXTERNAL_RGBA_DXT5, GLITypeFormat.TYPE_NONE),

            new GLIFormatDesc(8, 4,4,1, 4, 1, true, GLIInternalFormat.INTERNAL_R_ATI1N_UNORM, GLIExternalFormat.EXTERNAL_R_ATI1N_UNORM, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(8, 4,4,1, 4, 1, true, GLIInternalFormat.INTERNAL_R_ATI1N_SNORM, GLIExternalFormat.EXTERNAL_R_ATI1N_SNORM, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(16, 4,4,1, 8, 2, true, GLIInternalFormat.INTERNAL_RG_ATI2N_UNORM, GLIExternalFormat.EXTERNAL_RG_ATI2N_UNORM, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(16, 4,4,1, 8, 2, true, GLIInternalFormat.INTERNAL_RG_ATI2N_SNORM, GLIExternalFormat.EXTERNAL_RG_ATI2N_SNORM, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(16, 4,4,1,8, 3, true, GLIInternalFormat.INTERNAL_RGB_BP_UNSIGNED_FLOAT, GLIExternalFormat.EXTERNAL_RGB_BP_UNSIGNED_FLOAT, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(16, 4,4,1,8, 3, true, GLIInternalFormat.INTERNAL_RGB_BP_SIGNED_FLOAT, GLIExternalFormat.EXTERNAL_RGB_BP_SIGNED_FLOAT, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(16, 4,4,1,8,3, true, GLIInternalFormat.INTERNAL_RGB_BP_UNORM, GLIExternalFormat.EXTERNAL_RGB_BP_UNORM, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(8, 4,4,1, 4,3, true, GLIInternalFormat.INTERNAL_RGB_PVRTC_4BPPV1, GLIExternalFormat.EXTERNAL_RGB_PVRTC_4BPPV1, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(4, 4,4,1, 2,3, true, GLIInternalFormat.INTERNAL_RGB_PVRTC_2BPPV1, GLIExternalFormat.EXTERNAL_RGB_PVRTC_2BPPV1, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(8, 4,4,1, 4,4, true, GLIInternalFormat.INTERNAL_RGBA_PVRTC_4BPPV1, GLIExternalFormat.EXTERNAL_RGBA_PVRTC_4BPPV1, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(4, 4,4,1, 2,4, true, GLIInternalFormat.INTERNAL_RGBA_PVRTC_2BPPV1, GLIExternalFormat.EXTERNAL_RGBA_PVRTC_2BPPV1, GLITypeFormat.TYPE_NONE),

            new GLIFormatDesc(8, 4,4,1, 4, 3, true, GLIInternalFormat.INTERNAL_ATC_RGB, GLIExternalFormat.EXTERNAL_ATC_RGB, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(16, 4,4,1, 4,4, true, GLIInternalFormat.INTERNAL_ATC_RGBA_EXPLICIT_ALPHA, GLIExternalFormat.EXTERNAL_ATC_RGBA_EXPLICIT_ALPHA, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(16, 4,4,1, 4,4, true, GLIInternalFormat.INTERNAL_ATC_RGBA_INTERPOLATED_ALPHA, GLIExternalFormat.EXTERNAL_ATC_RGBA_INTERPOLATED_ALPHA, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(16, 4,4,1, 0, 4, true, GLIInternalFormat.INTERNAL_RGBA_ASTC_4x4, GLIExternalFormat.EXTERNAL_RGBA_ASTC_4x4, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(16, 5,4,1, 0, 4, true, GLIInternalFormat.INTERNAL_RGBA_ASTC_5x4, GLIExternalFormat.EXTERNAL_RGBA_ASTC_5x4, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(16, 5,5,1, 0, 4, true, GLIInternalFormat.INTERNAL_RGBA_ASTC_5x5, GLIExternalFormat.EXTERNAL_RGBA_ASTC_5x5, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(16, 6,5,1, 0, 4, true, GLIInternalFormat.INTERNAL_RGBA_ASTC_6x5, GLIExternalFormat.EXTERNAL_RGBA_ASTC_6x5, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(16, 6,6,1, 0, 4, true, GLIInternalFormat.INTERNAL_RGBA_ASTC_6x6, GLIExternalFormat.EXTERNAL_RGBA_ASTC_6x6, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(16, 8,5,1, 0, 4, true, GLIInternalFormat.INTERNAL_RGBA_ASTC_8x5, GLIExternalFormat.EXTERNAL_RGBA_ASTC_8x5, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(16, 8,6,1, 0, 4,true, GLIInternalFormat.INTERNAL_RGBA_ASTC_8x6, GLIExternalFormat.EXTERNAL_RGBA_ASTC_8x6, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(16, 8,8,1, 0, 4, true, GLIInternalFormat.INTERNAL_RGBA_ASTC_8x8, GLIExternalFormat.EXTERNAL_RGBA_ASTC_8x8, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(16, 10,5,1,0, 4, true, GLIInternalFormat.INTERNAL_RGBA_ASTC_10x5, GLIExternalFormat.EXTERNAL_RGBA_ASTC_10x5, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(16, 10,6,1,0, 4, true, GLIInternalFormat.INTERNAL_RGBA_ASTC_10x6, GLIExternalFormat.EXTERNAL_RGBA_ASTC_10x6, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(16, 10,8,1,0, 4, true, GLIInternalFormat.INTERNAL_RGBA_ASTC_10x8, GLIExternalFormat.EXTERNAL_RGBA_ASTC_10x8, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(16, 10,10,1,0,4, true, GLIInternalFormat.INTERNAL_RGBA_ASTC_10x10, GLIExternalFormat.EXTERNAL_RGBA_ASTC_10x10, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(16, 12,10,1,0,4, true, GLIInternalFormat.INTERNAL_RGBA_ASTC_12x10, GLIExternalFormat.EXTERNAL_RGBA_ASTC_12x10, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(16, 12,12,1,0,4, true, GLIInternalFormat.INTERNAL_RGBA_ASTC_12x12, GLIExternalFormat.EXTERNAL_RGBA_ASTC_12x12, GLITypeFormat.TYPE_NONE),

            // sRGB formats
            new GLIFormatDesc(24, 3, GLIInternalFormat.INTERNAL_SRGB8, GLIExternalFormat.EXTERNAL_RGB, GLITypeFormat.TYPE_U8),
            new GLIFormatDesc(32, 4, GLIInternalFormat.INTERNAL_SRGB8_ALPHA8, GLIExternalFormat.EXTERNAL_RGBA, GLITypeFormat.TYPE_U8),
            new GLIFormatDesc(8, 4,4,1, 4,3, true, GLIInternalFormat.INTERNAL_SRGB_DXT1, GLIExternalFormat.EXTERNAL_NONE, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(8, 4,4,1, 4,4, true, GLIInternalFormat.INTERNAL_SRGB_ALPHA_DXT1, GLIExternalFormat.EXTERNAL_NONE, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(16, 4,4,1, 8,4, true, GLIInternalFormat.INTERNAL_SRGB_ALPHA_DXT3, GLIExternalFormat.EXTERNAL_NONE, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(16, 4,4,1, 8,4, true, GLIInternalFormat.INTERNAL_SRGB_ALPHA_DXT5, GLIExternalFormat.EXTERNAL_NONE, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(16, 4,4,1, 8, 3,true, GLIInternalFormat.INTERNAL_SRGB_BP_UNORM, GLIExternalFormat.EXTERNAL_NONE, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(4, 4,4,1, 2,3, true, GLIInternalFormat.INTERNAL_SRGB_PVRTC_2BPPV1, GLIExternalFormat.EXTERNAL_RGB_PVRTC_2BPPV1, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(8, 4,4,1, 4,3, true, GLIInternalFormat.INTERNAL_SRGB_PVRTC_4BPPV1, GLIExternalFormat.EXTERNAL_RGB_PVRTC_4BPPV1, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(4, 4,4,1, 2,4,true, GLIInternalFormat.INTERNAL_SRGB_ALPHA_PVRTC_2BPPV1, GLIExternalFormat.EXTERNAL_RGB_PVRTC_2BPPV1, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(8, 4,4,1, 4,4, true, GLIInternalFormat.INTERNAL_SRGB_ALPHA_PVRTC_4BPPV1, GLIExternalFormat.EXTERNAL_RGB_PVRTC_4BPPV1, GLITypeFormat.TYPE_NONE),

            new GLIFormatDesc(16, 4,4,1, 0, 4,true, GLIInternalFormat.INTERNAL_SRGB8_ALPHA8_ASTC_4x4, GLIExternalFormat.EXTERNAL_RGBA_ASTC_4x4, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(16, 5,4,1, 0, 4,true, GLIInternalFormat.INTERNAL_SRGB8_ALPHA8_ASTC_5x4, GLIExternalFormat.EXTERNAL_RGBA_ASTC_5x4, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(16, 5,5,1, 0, 4,true, GLIInternalFormat.INTERNAL_SRGB8_ALPHA8_ASTC_5x5, GLIExternalFormat.EXTERNAL_RGBA_ASTC_5x5, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(16, 6,5,1, 0, 4,true, GLIInternalFormat.INTERNAL_SRGB8_ALPHA8_ASTC_6x5, GLIExternalFormat.EXTERNAL_RGBA_ASTC_6x5, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(16, 6,6,1, 0, 4,true, GLIInternalFormat.INTERNAL_SRGB8_ALPHA8_ASTC_6x6, GLIExternalFormat.EXTERNAL_RGBA_ASTC_6x6, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(16, 8,5,1, 0, 4,true, GLIInternalFormat.INTERNAL_SRGB8_ALPHA8_ASTC_8x5, GLIExternalFormat.EXTERNAL_RGBA_ASTC_8x5, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(16, 8,6,1, 0, 4,true, GLIInternalFormat.INTERNAL_SRGB8_ALPHA8_ASTC_8x6, GLIExternalFormat.EXTERNAL_RGBA_ASTC_8x6, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(16, 8,8,1, 0, 4,true, GLIInternalFormat.INTERNAL_SRGB8_ALPHA8_ASTC_8x8, GLIExternalFormat.EXTERNAL_RGBA_ASTC_8x8, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(16, 10,5,1, 0, 4,true, GLIInternalFormat.INTERNAL_SRGB8_ALPHA8_ASTC_10x5, GLIExternalFormat.EXTERNAL_RGBA_ASTC_10x5, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(16, 10,6,1, 0, 4,true, GLIInternalFormat.INTERNAL_SRGB8_ALPHA8_ASTC_10x6, GLIExternalFormat.EXTERNAL_RGBA_ASTC_10x6, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(16, 10,8,1, 0, 4,true, GLIInternalFormat.INTERNAL_SRGB8_ALPHA8_ASTC_10x8, GLIExternalFormat.EXTERNAL_RGBA_ASTC_10x8, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(16, 10,10,1, 0, 4,true, GLIInternalFormat.INTERNAL_SRGB8_ALPHA8_ASTC_10x10, GLIExternalFormat.EXTERNAL_RGBA_ASTC_10x10, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(16, 12,10,1, 0, 4,true, GLIInternalFormat.INTERNAL_SRGB8_ALPHA8_ASTC_12x10, GLIExternalFormat.EXTERNAL_RGBA_ASTC_12x10, GLITypeFormat.TYPE_NONE),
            new GLIFormatDesc(16, 12,12,1, 0, 4,true, GLIInternalFormat.INTERNAL_SRGB8_ALPHA8_ASTC_12x12, GLIExternalFormat.EXTERNAL_RGBA_ASTC_12x12, GLITypeFormat.TYPE_NONE),

        };


        internal static GLIFormatDesc GetFormatDesc(GLIFormat gliFormat)
        {
            //int format_last = (int)GLIFormat.FORMAT_LAST;

            Debug.Assert((int)GLIFormat.FORMAT_LAST == Desc.Length - 2, "GLIFormat and FormatDesc is in inbalance.");
            
            //return Desc[(int)gliFormat];
            //DIFF: Different from upstream.
            return Desc[(int)gliFormat + 1];
        }

    }
}
