#!/bin/bash
#
# RAGHU VARMA Build Script 
# Coded by RV 
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#      http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
#

clear

# Init Fields

Telegram_Api_code=
DRG=https://android.googleapis.com/packages/ota-api/nokia_drgsprout_dragon00ww/810351d123009ec07c1cb5857c4707fdeba776ef.zip
B2N=https://android.googleapis.com/packages/ota-api/nokia_b2nsprout_onyx00ww/3f78de06f86cc03da028648341aa1987fe33b2df.zip
PL2=https://android.googleapis.com/packages/ota-api/nokia_pl2sprout_plate200ww/be7e54518410d1752dd72f99dba3aecdee793bdb.zip
CTL=https://android.googleapis.com/packages/ota-api/nokia_ctlsprout_crystal00ww/b708f828b774c5d737530f3d1ea200db7a918308.zip
password=
path=/root

# Init Methods

DRG()
{
    mkdir DRG
    cd DRG
    wget $DRG
    unzip *.zip
    mkdir payload
    mkdir output
    cp -r payload.bin $path/DRG/payload
    cd payload
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/payload_dumper.py
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/update_metadata_pb2.py
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/img2simg
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/simg2img
    chmod a+x payload_dumper.py
    chmod a+x update_metadata_pb2.py
    chmod a+x simg2img
    chmod a+x img2simg
    ./payload_dumper.py payload.bin 
    sed -n 1p systeminfo.img > rv1.txt
    sed -e 's/\<mlf\>//g' rv1.txt  > rv2.txt
    sed -e 's/\MLF\>//g' rv2.txt > rv3.txt
    sed 's/,//g' rv3.txt > rv4.txt
    sed 's/.$//' rv4.txt > $path/rv5.txt
    buildnumber=$(grep "DRG" $path/rv5.txt)
    mv abl.img          $buildnumber-abl.img
    mv bluetooth.img    $buildnumber-bluetooth.img
    mv boot.img         $buildnumber-boot.img
    mv cda.img          $buildnumber-cda.img
    mv cmnlib.img       $buildnumber-cmnlib.img
    mv cmnlib64.img     $buildnumber-cmnlib64.img
    mv devcfg.img       $buildnumber-devcfg.img
    mv dsp.img          $buildnumber-dsp.img
    mv hidden.img       $buildnumber-hidden.img
    mv hyp.img          $buildnumber-hyp.img
    mv keymaster.img    $buildnumber-keymaster.img
    mv mdtp.img         $buildnumber-mdtp.img
    mv mdtpsecapp.img   $buildnumber-mdtpsecapp.img
    mv modem.img        $buildnumber-modem.img
    mv nvdef.img        $buildnumber-nvdef.img
    mv pmic.img         $buildnumber-pmic.img
    mv rpm.img          $buildnumber-rpm.img
    mv splash.img       $buildnumber-splash.img
    mv systeminfo.img   $buildnumber-systeminfo.img
    mv tz.img           $buildnumber-tz.img
    mv xbl.img          $buildnumber-xbl.img
    ./img2simg system.img $buildnumber-system.img
    ./img2simg vendor.img $buildnumber-vendor.img
    cp -r system.img $path
    rm -r system.img vendor.img
    cd
    cd $path
    mkdir system
    mount -o rw,noatime system.img system
    androidversion=`cat system/system/build.prop | grep ro.build.version.release | cut -d "=" -f 2`
    if [ $(echo $androidversion | cut -d "." -f 2) == 0 ]; then
    androidversion=$(echo $androidversion | cut -d "." -f 1)
    fi
    securitypatch=`cat system/system/build.prop | grep ro.build.version.security_patch | cut -d "=" -f 2`
    if [ $(echo $securitypatch | cut -d "." -f 2) == 0 ]; then
    securitypatch=$(echo $securitypatch | cut -d "." -f 1)
    fi    
    cd $path/DRG/payload
    zip -r $buildnumber-$androidversion.0-HB.zip *.img
    cp -r $buildnumber-$androidversion.0-HB.zip $path/DRG/output
    cd
    cd $path/DRG/output
    sshpass -p $password rsync -avP -e ssh $buildnumber-$androidversion.0-HB.zip raghuvarma331@frs.sourceforge.net:/home/frs/project/drg-sprout/STOCK-ROMS
    cd
    cd $path
    wget https://github.com/RaghuVarma331/scripts/raw/master/telegram.py
    wget https://github.com/RaghuVarma331/custom_roms_banners/raw/master/image.png
    python telegram.py -t $Telegram_Api_code -c @Nokia6plusofficial -P image.png -C " 
    *
    New Home Brew Stock Rom 
    Release is Up
    
    $(date)*
    
    ⬇️ [Download Rom](https://sourceforge.net/projects/drg-sprout/files/STOCK-ROMS/$buildnumber-$androidversion.0-HB.zip/download) 
    🔨 [Download flash tool](https://github.com/RaghuVarma331/Nokia-SDM660-Tool/releases)
    💬 [Flashing procedure](https://raw.githubusercontent.com/RaghuVarma331/changelogs/master/crossdevelopment/hbinstallation.txt)
    📱 Device: *Nokia 6.1 Plus*
    ⚡Build Version: *$buildnumber*
    ⚡Android Version: *$androidversion.0*
    ⚡Google Security Patch : *$securitypatch*
    👤 By: *Raghu Varma*
    #OTA #NOKIA #UPDATE #PATCH                                                                                                                                                                          
    Follow: @Nokia6plusofficial ✅" 
    umount system
    rm -r DRG system* rv5.txt   
}    

B2N()
{
    mkdir B2N
    cd B2N
    wget $B2N
    unzip *.zip
    mkdir payload
    mkdir output
    cp -r payload.bin $path/B2N/payload
    cd payload
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/payload_dumper.py
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/update_metadata_pb2.py
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/img2simg
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/simg2img
    chmod a+x payload_dumper.py
    chmod a+x update_metadata_pb2.py
    chmod a+x simg2img
    chmod a+x img2simg
    ./payload_dumper.py payload.bin 
    sed -n 1p systeminfo.img > rv1.txt
    sed -e 's/\<mlf\>//g' rv1.txt  > rv2.txt
    sed -e 's/\MLF\>//g' rv2.txt > rv3.txt
    sed 's/,//g' rv3.txt > rv4.txt
    sed 's/.$//' rv4.txt > $path/rv5.txt
    buildnumber=$(grep "B2N" $path/rv5.txt)
    mv abl.img          $buildnumber-abl.img
    mv bluetooth.img    $buildnumber-bluetooth.img
    mv boot.img         $buildnumber-boot.img
    mv cda.img          $buildnumber-cda.img
    mv cmnlib.img       $buildnumber-cmnlib.img
    mv cmnlib64.img     $buildnumber-cmnlib64.img
    mv devcfg.img       $buildnumber-devcfg.img
    mv dsp.img          $buildnumber-dsp.img
    mv hidden.img       $buildnumber-hidden.img
    mv hyp.img          $buildnumber-hyp.img
    mv keymaster.img    $buildnumber-keymaster.img
    mv mdtp.img         $buildnumber-mdtp.img
    mv mdtpsecapp.img   $buildnumber-mdtpsecapp.img
    mv modem.img        $buildnumber-modem.img
    mv nvdef.img        $buildnumber-nvdef.img
    mv pmic.img         $buildnumber-pmic.img
    mv rpm.img          $buildnumber-rpm.img
    mv splash.img       $buildnumber-splash.img
    mv systeminfo.img   $buildnumber-systeminfo.img
    mv tz.img           $buildnumber-tz.img
    mv xbl.img          $buildnumber-xbl.img
    ./img2simg system.img $buildnumber-system.img
    ./img2simg vendor.img $buildnumber-vendor.img
    cp -r system.img $path
    rm -r system.img vendor.img
    cd
    cd $path
    mkdir system
    mount -o rw,noatime system.img system
    androidversion=`cat system/system/build.prop | grep ro.build.version.release | cut -d "=" -f 2`
    if [ $(echo $androidversion | cut -d "." -f 2) == 0 ]; then
    androidversion=$(echo $androidversion | cut -d "." -f 1)
    fi
    securitypatch=`cat system/system/build.prop | grep ro.build.version.security_patch | cut -d "=" -f 2`
    if [ $(echo $securitypatch | cut -d "." -f 2) == 0 ]; then
    securitypatch=$(echo $securitypatch | cut -d "." -f 1)
    fi    
    cd $path/B2N/payload
    zip -r $buildnumber-$androidversion.0-HB.zip *.img
    cp -r $buildnumber-$androidversion.0-HB.zip $path/B2N/output
    cd
    cd $path/B2N/output
    sshpass -p $password rsync -avP -e ssh $buildnumber-$androidversion.0-HB.zip raghuvarma331@frs.sourceforge.net:/home/frs/project/b2n-sprout/STOCK-ROMS
    cd
    cd $path
    wget https://github.com/RaghuVarma331/scripts/raw/master/telegram.py
    wget https://github.com/RaghuVarma331/custom_roms_banners/raw/master/image.png
    python telegram.py -t $Telegram_Api_code -c @Nokia7plusOfficial -P image.png -C " 
    *
    New Home Brew Stock Rom 
    Release is Up
    
    $(date)*
    
    ⬇️ [Download Rom](https://sourceforge.net/projects/b2n-sprout/files/STOCK-ROMS/$buildnumber-$androidversion.0-HB.zip/download) 
    🔨 [Download flash tool](https://github.com/RaghuVarma331/Nokia-SDM660-Tool/releases)
    💬 [Flashing procedure](https://raw.githubusercontent.com/RaghuVarma331/changelogs/master/crossdevelopment/hbinstallation.txt)
    📱 Device: *Nokia 7 Plus*
    ⚡Build Version: *$buildnumber*
    ⚡Android Version: *$androidversion.0*
    ⚡Google Security Patch : *$securitypatch*
    👤 By: *Raghu Varma*
    #OTA #NOKIA #UPDATE #PATCH                                                                                                                                                                          
    Follow: @Nokia7plusOfficial ✅" 
    umount system
    rm -r B2N system* rv5.txt  
}  

PL2()
{
    mkdir PL2
    cd PL2
    wget $PL2
    unzip *.zip
    mkdir payload
    mkdir output
    cp -r payload.bin $path/PL2/payload
    cd payload
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/payload_dumper.py
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/update_metadata_pb2.py
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/img2simg
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/simg2img
    chmod a+x payload_dumper.py
    chmod a+x update_metadata_pb2.py
    chmod a+x simg2img
    chmod a+x img2simg
    ./payload_dumper.py payload.bin 
    sed -n 1p systeminfo.img > rv1.txt
    sed -e 's/\<mlf\>//g' rv1.txt  > rv2.txt
    sed -e 's/\MLF\>//g' rv2.txt > rv3.txt
    sed 's/,//g' rv3.txt > rv4.txt
    sed 's/.$//' rv4.txt > $path/rv5.txt
    buildnumber=$(grep "PL2" $path/rv5.txt)
    mv abl.img          $buildnumber-abl.img
    mv bluetooth.img    $buildnumber-bluetooth.img
    mv boot.img         $buildnumber-boot.img
    mv cda.img          $buildnumber-cda.img
    mv cmnlib.img       $buildnumber-cmnlib.img
    mv cmnlib64.img     $buildnumber-cmnlib64.img
    mv devcfg.img       $buildnumber-devcfg.img
    mv dsp.img          $buildnumber-dsp.img
    mv hidden.img       $buildnumber-hidden.img
    mv hyp.img          $buildnumber-hyp.img
    mv keymaster.img    $buildnumber-keymaster.img
    mv mdtp.img         $buildnumber-mdtp.img
    mv mdtpsecapp.img   $buildnumber-mdtpsecapp.img
    mv modem.img        $buildnumber-modem.img
    mv nvdef.img        $buildnumber-nvdef.img
    mv pmic.img         $buildnumber-pmic.img
    mv rpm.img          $buildnumber-rpm.img
    mv splash.img       $buildnumber-splash.img
    mv systeminfo.img   $buildnumber-systeminfo.img
    mv tz.img           $buildnumber-tz.img
    mv xbl.img          $buildnumber-xbl.img
    ./img2simg system.img $buildnumber-system.img
    ./img2simg vendor.img $buildnumber-vendor.img
    cp -r system.img $path
    rm -r system.img vendor.img
    cd
    cd $path
    mkdir system
    mount -o rw,noatime system.img system
    androidversion=`cat system/system/build.prop | grep ro.build.version.release | cut -d "=" -f 2`
    if [ $(echo $androidversion | cut -d "." -f 2) == 0 ]; then
    androidversion=$(echo $androidversion | cut -d "." -f 1)
    fi
    securitypatch=`cat system/system/build.prop | grep ro.build.version.security_patch | cut -d "=" -f 2`
    if [ $(echo $securitypatch | cut -d "." -f 2) == 0 ]; then
    securitypatch=$(echo $securitypatch | cut -d "." -f 1)
    fi    
    cd $path/PL2/payload
    zip -r $buildnumber-$androidversion.0-HB.zip *.img
    cp -r $buildnumber-$androidversion.0-HB.zip $path/PL2/output
    cd
    cd $path/PL2/output
    sshpass -p $password rsync -avP -e ssh $buildnumber-$androidversion.0-HB.zip raghuvarma331@frs.sourceforge.net:/home/frs/project/pl2-sprout/STOCK-ROMS
    cd
    cd $path
    wget https://github.com/RaghuVarma331/scripts/raw/master/telegram.py
    wget https://github.com/RaghuVarma331/custom_roms_banners/raw/master/image.png
    python telegram.py -t $Telegram_Api_code -c @nokia7161 -P image.png -C " 
    *
    New Home Brew Stock Rom 
    Release is Up
    
    $(date)*
    
    ⬇️ [Download Rom](https://sourceforge.net/projects/pl2-sprout/files/STOCK-ROMS/$buildnumber-$androidversion.0-HB.zip/download) 
    🔨 [Download flash tool](https://github.com/RaghuVarma331/Nokia-SDM660-Tool/releases)
    💬 [Flashing procedure](https://raw.githubusercontent.com/RaghuVarma331/changelogs/master/crossdevelopment/hbinstallation.txt)
    📱 Device: *Nokia 6.1*
    ⚡Build Version: *$buildnumber*
    ⚡Android Version: *$androidversion.0*
    ⚡Google Security Patch : *$securitypatch*
    👤 By: *Raghu Varma*
    #OTA #NOKIA #UPDATE #PATCH                                                                                                                                                                          
    Follow: @nokia7161 ✅" 
    umount system
    rm -r PL2 system* rv5.txt    
}  

CTL()
{
    mkdir CTL
    cd CTL
    wget $CTL
    unzip *.zip
    mkdir payload
    mkdir output
    cp -r payload.bin $path/CTL/payload
    cd payload
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/payload_dumper.py
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/update_metadata_pb2.py
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/img2simg
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/simg2img
    chmod a+x payload_dumper.py
    chmod a+x update_metadata_pb2.py
    chmod a+x simg2img
    chmod a+x img2simg
    ./payload_dumper.py payload.bin 
    sed -n 1p systeminfo.img > rv1.txt
    sed -e 's/\<mlf\>//g' rv1.txt  > rv2.txt
    sed -e 's/\MLF\>//g' rv2.txt > rv3.txt
    sed 's/,//g' rv3.txt > rv4.txt
    sed 's/.$//' rv4.txt > $path/rv5.txt
    buildnumber=$(grep "CTL" $path/rv5.txt)
    mv abl.img          $buildnumber-abl.img
    mv bluetooth.img    $buildnumber-bluetooth.img
    mv boot.img         $buildnumber-boot.img
    mv cda.img          $buildnumber-cda.img
    mv cmnlib.img       $buildnumber-cmnlib.img
    mv cmnlib64.img     $buildnumber-cmnlib64.img
    mv devcfg.img       $buildnumber-devcfg.img
    mv dsp.img          $buildnumber-dsp.img
    mv hidden.img       $buildnumber-hidden.img
    mv hyp.img          $buildnumber-hyp.img
    mv keymaster.img    $buildnumber-keymaster.img
    mv mdtp.img         $buildnumber-mdtp.img
    mv mdtpsecapp.img   $buildnumber-mdtpsecapp.img
    mv modem.img        $buildnumber-modem.img
    mv nvdef.img        $buildnumber-nvdef.img
    mv pmic.img         $buildnumber-pmic.img
    mv rpm.img          $buildnumber-rpm.img
    mv splash.img       $buildnumber-splash.img
    mv systeminfo.img   $buildnumber-systeminfo.img
    mv tz.img           $buildnumber-tz.img
    mv xbl.img          $buildnumber-xbl.img
    ./img2simg system.img $buildnumber-system.img
    ./img2simg vendor.img $buildnumber-vendor.img
    cp -r system.img $path
    rm -r system.img vendor.img
    cd
    cd $path
    mkdir system
    mount -o rw,noatime system.img system
    androidversion=`cat system/system/build.prop | grep ro.build.version.release | cut -d "=" -f 2`
    if [ $(echo $androidversion | cut -d "." -f 2) == 0 ]; then
    androidversion=$(echo $androidversion | cut -d "." -f 1)
    fi
    securitypatch=`cat system/system/build.prop | grep ro.build.version.security_patch | cut -d "=" -f 2`
    if [ $(echo $securitypatch | cut -d "." -f 2) == 0 ]; then
    securitypatch=$(echo $securitypatch | cut -d "." -f 1)
    fi    
    cd $path/CTL/payload
    zip -r $buildnumber-$androidversion.0-HB.zip *.img
    cp -r $buildnumber-$androidversion.0-HB.zip $path/CTL/output
    cd
    cd $path/CTL/output
    sshpass -p $password rsync -avP -e ssh $buildnumber-$androidversion.0-HB.zip raghuvarma331@frs.sourceforge.net:/home/frs/project/ctl-sprout/STOCK-ROMS
    cd
    cd $path
    wget https://github.com/RaghuVarma331/scripts/raw/master/telegram.py
    wget https://github.com/RaghuVarma331/custom_roms_banners/raw/master/image.png
    python telegram.py -t $Telegram_Api_code -c @nokia7161 -P image.png -C " 
    *
    New Home Brew Stock Rom 
    Release is Up
    
    $(date)*
    
    ⬇️ [Download Rom](https://sourceforge.net/projects/ctl-sprout/files/STOCK-ROMS/$buildnumber-$androidversion.0-HB.zip/download) 
    🔨 [Download flash tool](https://github.com/RaghuVarma331/Nokia-SDM660-Tool/releases)
    💬 [Flashing procedure](https://raw.githubusercontent.com/RaghuVarma331/changelogs/master/crossdevelopment/hbinstallation.txt)
    📱 Device: *Nokia 7.1*
    ⚡Build Version: *$buildnumber*
    ⚡Android Version: *$androidversion.0*
    ⚡Google Security Patch : *$securitypatch*
    👤 By: *Raghu Varma*
    #OTA #NOKIA #UPDATE #PATCH                                                                                                                                                                          
    Follow: @nokia7161 ✅" 
    umount system
    rm -r CTL system* rv5.txt    
} 

# Main Menu
clear
echo "-----------------------------------------------------------"
echo "A simple tool to make home brew stock rom from Full OTA.zip"
echo "Coded By Raghu Varma.G "
echo "-----------------------------------------------------------"
PS3='Please select your option (1-4): '
menuvar=("DRG" "B2N" "CTL" "PL2" "Exit")
select menuvar in "${menuvar[@]}"
do
    case $menuvar in
        "DRG")
            clear
            echo "----------------------------------------------"           
            echo "Please be patient..."
            # DRG
            echo "----------------------------------------------"
            echo "Posting in channel..."
            echo " "
            DRG
	    echo " "	    
            echo "----------------------------------------------"
            echo "Posting in Channel finished."
            echo " "
            echo "----------------------------------------------"
            echo "Press any key for end the script."
            echo "----------------------------------------------"
            read -n1 -r key
            break
            ;;	    
        "B2N")
            clear
            echo "----------------------------------------------"           
            echo "Please be patient..."
            # B2N
            echo "----------------------------------------------"
            echo "Posting in channel..."
            echo " "
            B2N
	    echo " "	    
            echo "----------------------------------------------"
            echo "Posting in Channel finished."
            echo " "
            echo "----------------------------------------------"
            echo "Press any key for end the script."
            echo "----------------------------------------------"
            read -n1 -r key
            break
            ;;	
        "PL2")
            clear
            echo "----------------------------------------------"           
            echo "Please be patient..."
            # PL2
            echo "----------------------------------------------"
            echo "Posting in channel..."
            echo " "
            PL2
	    echo " "	    
            echo "----------------------------------------------"
            echo "Posting in Channel finished."
            echo " "
            echo "----------------------------------------------"
            echo "Press any key for end the script."
            echo "----------------------------------------------"
            read -n1 -r key
            break
            ;;	
        "CTL")
            clear
            echo "----------------------------------------------"           
            echo "Please be patient..."
            # CTL
            echo "----------------------------------------------"
            echo "Posting in channel..."
            echo " "
            CTL
	    echo " "	    
            echo "----------------------------------------------"
            echo "Posting in Channel finished."
            echo " "
            echo "----------------------------------------------"
            echo "Press any key for end the script."
            echo "----------------------------------------------"
            read -n1 -r key
            break
            ;;		    
        "Exit")
            break
            ;;
        *) echo Invalid option.;;
    esac
done   
            
