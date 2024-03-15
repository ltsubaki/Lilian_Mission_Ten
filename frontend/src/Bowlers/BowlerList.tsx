import { useEffect, useState } from 'react';
import { Bowler } from '../types/Bowler';
function BowlerList() {

    const [BowlingData, setBowlingData] = useState<Bowler[]>([]);

    useEffect(() => {
        const fetchData = async () => {
            const rsp = await fetch('http://localhost:5210/api/Bowler');
            const b = await rsp.json();
            setBowlingData(b);
        };

        fetchData();
    }, []);

    return (
        <>
            <div className="row">
                <h4 className="text-center">Bowlers in the Marlins or Sharks Team</h4>
            </div>
            <table className="table table-bordered">
                <thead>
                    <th>Bowler Name</th>
                    <th>Team Name</th>
                    <th>Address</th>
                    <th>City</th>
                    <th>State</th>
                    <th>Zip</th>
                    <th>Phone Number</th>
                </thead>
                <tbody>
                    {BowlingData.map((b) => (
                        <tr key={b.bowlerId}>
                            <td>{b.bowlerFirstName}</td>
                            <td>{b.teamName}</td>
                            <td>{b.bowlerAddress}</td>
                            <td>{b.bowlerCity}</td>
                            <td>{b.bowlerState}</td>
                            <td>{b.bowlerZip}</td>
                            <td>{b.bowlerPhoneNumber}</td>
                        </tr>
                    ))}
                </tbody>

            </table>
        </>
    );
}

export default BowlerList;